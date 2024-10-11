using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_LuongDinhHoang
{
    internal abstract class BaseXe
    {
        protected static int autoID = 0;
        public string TenXe { get; set; }
        public int NamSX { get; set; }
        public string BienSoXe { get; set; }
        public double GiaBan { get; set; }
    }

    internal class Xe : BaseXe
    {
        public Xe() { }

        public Xe(string id)
        {
            BienSoXe = id == null ? $"XE{autoID++}" : id;
        }

        public Xe(string id, string tenxe, int nam, double giaban ) : this(id)
        {
            TenXe = tenxe;
            NamSX = nam;
            GiaBan = giaban;
        }
    }

    internal class XeDien : Xe
    {
        public int Pin { get; set; }
        public XeDien() { }
        public XeDien(string id)
        {
            BienSoXe = id == null ? $"XEDIEN{autoID++}" : id;
        }

        public XeDien(string id, string tenxe, int nam, double giaban, int pin) :this(id)
        {
            TenXe = tenxe;
            NamSX = nam;
            GiaBan = giaban;
            Pin = pin;
        }
    }
}
