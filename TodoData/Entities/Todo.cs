using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TodoData.Entities
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime DateGenerated { get; set; } 
        public DateTime DateUpdated { get; set; } 
        public int Status { get; set; }
        public DateTime? FinishDate { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }       
        public virtual User User { get; set; }

    }
}
