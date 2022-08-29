using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZ_Teller_Prototype
{
    public class General
    {
        // Only allows nums and control characters as input
        public static bool isNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else { return false; }
        }
    }
}
