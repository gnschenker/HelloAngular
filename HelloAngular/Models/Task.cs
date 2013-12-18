using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloAngular.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }

    public enum TaskStatus
    {
        Undefined = 0,
        Pending = 1,
        Started = 2,
        Done = 3,
        Cancelled = 4
    }
}