using System;

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
    }
}
