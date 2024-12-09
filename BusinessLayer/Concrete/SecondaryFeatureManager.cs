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
    public class SecondaryFeatureManager : ISecondaryFeatureService
    {

        private readonly ISecondaryFeatureDal secondaryFeatureDal;

        public SecondaryFeatureManager(ISecondaryFeatureDal secondaryFeatureDal)
        {
            this.secondaryFeatureDal = secondaryFeatureDal;
        }

        public void TDelete(int id)
        {
          secondaryFeatureDal.Delete(id);
        }

        public List<SecondaryFeature> TGetAll()
        {
           return secondaryFeatureDal.GetAll(); 
        }

        public SecondaryFeature TGetById(int id)
        {
           return secondaryFeatureDal.GetById(id);
        }

        public void TInsert(SecondaryFeature entity)
        {
           secondaryFeatureDal.Insert(entity);
        }

        public void TUpdate(SecondaryFeature entity)
        {
            secondaryFeatureDal.Update(entity);
        }
    }
}
