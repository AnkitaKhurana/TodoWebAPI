using DataAccess.Mapper;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoData.Entities;

namespace DataAccess.Data
{
    public class TodoData
    {
        private TodoContext db = new TodoContext();

        public bool AddTodo(TodoDTO todo, string user)
        {
            try
            {
                var userfound = db.Users.Where(x => x.UserName == user).FirstOrDefault();

                Todo todoDB = TodoMapper.ToDB(todo);
                todoDB.Id = Guid.NewGuid();
                todoDB.DateGenerated = DateTime.Now;
                todoDB.DateUpdated = todoDB.DateGenerated;
                todoDB.Status = 1;
               // todoDB.User = userfound;
                todoDB.UserId = userfound.Id;
                db.Todos.Add(todoDB);
                db.SaveChanges();
                return true;
            }          
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
