using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWebApi.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime DateGenerated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int Status { get; set; }
        public DateTime? FinishDate { get; set; }
        public Guid UserId { get; set; }
    }
}