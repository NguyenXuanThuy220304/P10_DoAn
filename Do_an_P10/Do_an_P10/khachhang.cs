using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_P10
{
    internal class khachhang
    {
        private string hoten;
        private string sdt;
        private string diachi;

        public khachhang() { }

        public khachhang(string hoten, string sdt, string diachi)
        {
            this.hoten = hoten;
            this.sdt = sdt;
            this.diachi = diachi;
        }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
