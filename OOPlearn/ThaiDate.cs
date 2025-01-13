using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPlearn
{
    internal class ThaiDate
    {
        public static int GetCurrentThaiYear()
        {
            return (int)DateTime.Now.Year+543;
        }

        public static int GetCurrentYear()
        {
            return (int)DateTime.Now.Year;
        }

        public enum ThaiDayName
        {
            อาทิตย์,จันทร์,อังคาร,พุธ,พฤหัสบดี,ศุกร์,เสาร์
        }
    }
}
