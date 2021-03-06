using System;
using System.Collections.Generic;

#nullable disable

namespace DevTask
{
    public partial class DevUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }
}
