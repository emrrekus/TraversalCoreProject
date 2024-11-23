using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key] 
        public int GuideId { get; set; }
        public int Name {  get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public bool Status { get; set; }

        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
    }
}
