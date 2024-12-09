﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EfTestimonialsDal : GenericRepository<Testimonials>, ITestimonialsDal
    {
        public EfTestimonialsDal(Context context) : base(context)
        {
        }
    }
}