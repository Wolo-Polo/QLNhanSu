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
    public class TrinhDo_BUL
    {
        private TrinhDo_DAL trinhDo_DAL = new TrinhDo_DAL();

        public DataTable getAllTrinhDo()
        {
            return trinhDo_DAL.getAllTrinhDo();
        }

        public void insertTrinhDo(TrinhDo trinhDo)
        {
            trinhDo_DAL.insertTrinhDo(trinhDo);
        }

        public void updateTrinhDo(TrinhDo trinhDo)
        {
            trinhDo_DAL.updateTrinhDo(trinhDo);
        }

        public void deleteTrinhDo(TrinhDo trinhDo)
        {
            trinhDo_DAL.deleteTrinhDo(trinhDo);
        }

        public DataTable findTrinhDo(TrinhDo trinhDo)
        {
            return trinhDo_DAL.findTrinhDo(trinhDo);
        }
    }
}
