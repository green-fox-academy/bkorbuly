using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_01_TODO.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Isurgent { get; set; } = false;
        public bool Isdone { get; set; } = false;
    }
}
