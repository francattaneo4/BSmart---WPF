using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSmart___WPF
{
    public class Parametro
    {
        public int CalcularSuperficie(int valFondo, int valFrente)
        {
            int vSup = 0;
            vSup = valFondo + valFrente;
            return vSup;
        }
    }
}
