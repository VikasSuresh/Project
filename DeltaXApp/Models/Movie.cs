using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeltaXApp.Models
{
    public class Movie
    {
        public int Movie_id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Plot { get; set; }
        
    }
}