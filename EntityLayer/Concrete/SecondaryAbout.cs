﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SecondaryAbout
    {

        [Key]
        public int SecondaryAboutId { get; set; }
        public string Title { get; set; }
        public string SecondaryTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
