﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> TGetListWithReservationByAccepted(int id);
        List<Reservation> TGetListWithReservationByPrevious(int id);
        List<Reservation> TGetListWithReservationByWaitAprroval(int id);
    }
}
