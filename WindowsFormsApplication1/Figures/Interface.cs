using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Figures
{
    interface Interface
    {
         
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double Area { get; }

        /// <summary>
        /// Расчет площади фигуры.
        /// </summary>
        /// <returns></returns>
        double Calculate();
    }
}
