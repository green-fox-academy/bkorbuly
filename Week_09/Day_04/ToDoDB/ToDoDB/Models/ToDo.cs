using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoDB.Models
{
    public class ToDo
    {
        public long id;
        public string title;
        public bool isUrgent = false;
        public bool isDone = false;

    }
}
