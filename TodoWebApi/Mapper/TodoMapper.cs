using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoWebApi.Models;

namespace TodoWebApi.Mapper
{
    public class TodoMapper
    {
        public static TodoDTO ToDTO(Todo todo)
        {
            return new TodoDTO()
            {
                Id = todo.Id,
                DateGenerated = todo.DateGenerated,
                DateUpdated = todo.DateUpdated,
                FinishDate = todo.FinishDate,
                Message = todo.Message,
                Status = todo.Status,
                UserId = todo.UserId,
            };

        }
    }
}