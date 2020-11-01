using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDo
    {
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private String ngang;

        public String Nganh
        {
            get { return ngang; }
            set { ngang = value; }
        }

        private String trinhDoDaoTao;

        public String TrinhDoDaoTao
        {
            get { return trinhDoDaoTao; }
            set { trinhDoDaoTao = value; }
        }
        private String truong;

        public String Truong
        {
            get { return truong; }
            set { truong = value; }
        }

    }
}
