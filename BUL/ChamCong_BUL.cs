using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChamCong_BUL
    {
        private ChamCong_DAL cc = new ChamCong_DAL();
        public DataTable getAllChamcong()
        {
            return cc.getAllChamCong();
        }
        public Boolean insertChamcong(ChamCong_DTO c)
        {
            return cc.insertChamCong(c);
        }
        public Boolean updateChamcong(ChamCong_DTO c)
        {
            return cc.updateChamCong(c);
        }
        public Boolean deleteChamcong(ChamCong_DTO c)
        {
            return cc.deleteChamCong(c);
        }
        public DataTable findChamCong(ChamCong_DTO c)
        {
            return cc.findChamCong(c);
        }
    }
}
