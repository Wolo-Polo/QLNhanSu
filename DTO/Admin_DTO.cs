﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Admin_DTO
    {
        private string taikhoan;
        private string matkhau;
        public Admin_DTO()
        {

        }

        public Admin_DTO(string taikhoan, string matkhau)
        {
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
