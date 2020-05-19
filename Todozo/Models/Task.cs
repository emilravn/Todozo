using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todozo
{
    public class Task
    {
        public int TaskID { get; set; } 
        public int ListID { get; set; } 
        public bool Status { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 
        public DateTime Deadline { get; set; }
        public int Priority { get; set; } 

        public string FullInfo
        {
            get
            {
                return $"{Name} {Description}";
            }
        }
    }
}
