using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_mvc_website.Models
{
    public class ToDo
    {
        public int ToDoId { get; set; }
        public string ToDoName { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
