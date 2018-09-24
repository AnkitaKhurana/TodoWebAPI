using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using TD = DataAccess.Data.TodoData;


namespace BusinessLogic.Logic
{
    public class TodoLogic
    {
        private TD todoData = new TD();

        public bool AddNewTodo(TodoDTO todoDTO, string userId)
        {
            try
            {
                if(todoData.AddTodo(todoDTO, userId))
                    return true;

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
