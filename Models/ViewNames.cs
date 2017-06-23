using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class ViewNames
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Select a Branch")]
        public Nullable<int> Branch { get; set; }
        public string BranchName { get; set; }

        public bool Remember { get; set; }
    }
}