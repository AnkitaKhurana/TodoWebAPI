using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using TodoData.Entities;

namespace DataAccess.Mapper
{
    public class TodoMapper
    {
        public static Todo ToDB(TodoDTO todoDTO)
        {
            Todo todo = new Todo()
            {
                Id = todoDTO.Id,
                Message = todoDTO.Message,
                DateGenerated = todoDTO.DateGenerated,
                DateUpdated = todoDTO.DateUpdated,
                Status = todoDTO.Status,
                FinishDate = todoDTO.FinishDate,
                UserId = todoDTO.UserId

            };
            return todo;
        }
    }
}
