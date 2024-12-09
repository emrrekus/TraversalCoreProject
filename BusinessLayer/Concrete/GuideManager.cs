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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
           _guideDal = guideDal;
        }

        public void TDelete(int id)
        {
            _guideDal.Delete(id);
        }

        public List<Guide> TGetAll()
        {
            return _guideDal.GetAll();  
        }

        public Guide TGetById(int id)
        {
           return _guideDal.GetById(id);
        }

        public void TInsert(Guide entity)
        {
           _guideDal.Insert(entity);
        }

        public void TUpdate(Guide entity)
        {
            _guideDal.Update(entity);
        }
    }
}
