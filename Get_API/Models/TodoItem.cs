using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get_API.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Iscomplete { get; set; }
    }
}
