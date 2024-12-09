using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialsManager : ITestimonialsService
    {
        private readonly ITestimonialsDal testimonialsDal;

        public TestimonialsManager(ITestimonialsDal testimonialsDal)
        {
            this.testimonialsDal = testimonialsDal;
        }

        public void TDelete(int id)
        {
            testimonialsDal.Delete(id);
        }

        public List<Testimonials> TGetAll()
        {
            return testimonialsDal.GetAll();
        }

        public Testimonials TGetById(int id)
        {
            return testimonialsDal.GetById(id);
        }

        public void TInsert(Testimonials entity)
        {
            testimonialsDal.Insert(entity);
        }

        public void TUpdate(Testimonials entity)
        {
            testimonialsDal.Update(entity);
        }
    }
}
