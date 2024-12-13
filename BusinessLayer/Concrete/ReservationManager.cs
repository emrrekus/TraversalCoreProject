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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void TDelete(int id)
        {
           _reservationDal.Delete(id);  
        }

        public List<Reservation> TGetAll()
        {
            return _reservationDal.GetAll();
        }

        public Reservation TGetById(int id)
        {
          return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> TGetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> TGetListWithReservationByWaitAprroval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAprroval(id);
        }

        public void TInsert(Reservation entity)
        {
           _reservationDal.Insert(entity);
        }

        public void TUpdate(Reservation entity)
        {
           _reservationDal.Update(entity);
        }
    }
}
