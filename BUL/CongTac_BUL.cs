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
    public class CongTac_BUL
    {
        private CongTac_DAL congTac_DAL = new CongTac_DAL();
        public DataTable getAllCongTac()
        {
            return congTac_DAL.getAllCongTac();
        }
        public int insertCongTac(CongTac_DTO ct)
        {
            return congTac_DAL.insertCongTac(ct);
        }
        public int updateCongTac(CongTac_DTO ct)
        {
            return congTac_DAL.updateCongTac(ct);
        }
        public int deleteCongTac(string manv, string ngaycongtac)
        {
            return congTac_DAL.deleteCongTac(manv, ngaycongtac);
        }
        public DataTable timkiemCongTac(CongTac_DTO ct)
        {
            return congTac_DAL.timkiemCongTac(ct);
        }
    }

}
