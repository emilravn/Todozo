using System;

namespace Todozo.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Guid UserGuid { get; set; }
    }
}
