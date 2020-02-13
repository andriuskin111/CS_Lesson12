using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class RaportTotalHoursRepository
    {
        private List<RaportTotalHours> _raportTotalHours;

        public RaportTotalHoursRepository(List<RaportTotalHours> raportTotalHours)
        {
            _raportTotalHours = raportTotalHours;
        }

        public List<RaportTotalHours> Retrieve()
        {
            return _raportTotalHours;
        }
    }
}
