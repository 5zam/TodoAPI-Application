using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DAL.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<TodoTask> Tasks { get; set; } = new List<TodoTask>();
    }
}
