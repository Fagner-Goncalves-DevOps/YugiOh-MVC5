using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AspNet5Mvc_YuGiOh.Models
{
    public class FilterParams 
    {
        public string type { get; set; }
        public int? level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }

    }
}
