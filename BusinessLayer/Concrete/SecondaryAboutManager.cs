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
    public class SecondaryAboutManager : ISecondaryAboutService
    {
        private readonly ISecondaryAboutDal _secondaryAboutDal;

        public SecondaryAboutManager(ISecondaryAboutDal secondaryAboutDal)
        {
            _secondaryAboutDal = secondaryAboutDal;
        }

        public void TDelete(int id)
        {
            _secondaryAboutDal.Delete(id);
        }

        public List<SecondaryAbout> TGetAll()
        {
            return _secondaryAboutDal.GetAll();
        }

        public SecondaryAbout TGetById(int id)
        {
            return _secondaryAboutDal.GetById(id);
        }

        public void TInsert(SecondaryAbout entity)
        {
            _secondaryAboutDal.Insert(entity);
        }

        public void TUpdate(SecondaryAbout entity)
        {
          _secondaryAboutDal.Update(entity);    
        }
    }
}
