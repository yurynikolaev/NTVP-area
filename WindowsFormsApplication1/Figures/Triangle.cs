using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Figures
{
    /// <summary>
    /// Triangle class
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Initialisation height
        /// </summary>
        private double _height;
        /// <summary>
        /// Initialization catet
        /// </summary>
        private double _catet;
        /// <summary>
        /// Validation height
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательная высота!");
                }
                _height = value;
            }
        }
        /// <summary>
        /// Validation catet
        /// </summary>
        public double Catet
        {
            get
            {
                return _catet;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательная сторона!");
                }
                _catet = value;
            }
        }
        /// <summary>
        /// Counting triangle's area
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double area;
            area = 0.5 * _catet * _height;
            return area;
        }
    }
}
