using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPTWebApplication.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BDay { get; set; }
        public string Course { get; set; }

    }
}