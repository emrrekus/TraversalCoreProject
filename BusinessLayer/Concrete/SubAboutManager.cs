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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            this.subAboutDal = subAboutDal;
        }

        public void TDelete(int id)
        {
            subAboutDal.Delete(id);
        }

        public List<SubAbout> TGetAll()
        {
           return subAboutDal.GetAll(); 
        }

        public SubAbout TGetById(int id)
        {
           return subAboutDal.GetById(id);
        }

        public void TInsert(SubAbout entity)
        {
            subAboutDal.Insert(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            subAboutDal.Update(entity);
        }
    }
}
