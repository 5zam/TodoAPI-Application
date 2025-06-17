using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DAL.Models
{
    public class TodoTask : BaseEntity
    {
        public string? TaskName { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime Deadline { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
