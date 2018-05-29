using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeltaXApp.Models
{
    public class Producer
    {
        public int Producer_id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Bio { get; set; }
        public Nullable<int> Movieid { get; set; }
    }
}