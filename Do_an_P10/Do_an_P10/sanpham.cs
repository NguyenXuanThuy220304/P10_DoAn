using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_P10
{
    public class sanpham
    {
        public string Tensanpham { get; set; }
        public decimal  Dongia { get; set; }
        public int Soluong { get; set; }
        public Image Hinhanh { get; set; }

        public sanpham() { }

        public sanpham(string tensanpham, decimal dongia, int soluong, Image hinhanh)
        {
            this.Tensanpham = tensanpham;
            this.Dongia = dongia;
            this.Soluong = soluong;
            this.Hinhanh = hinhanh;
        }
    }
}
