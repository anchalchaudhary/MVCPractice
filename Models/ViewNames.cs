using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class ViewNames
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Branch { get; set; }
        public string BranchName { get; set; }

        public bool Remember { get; set; }
    }
}