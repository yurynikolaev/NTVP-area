using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Figures
{
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Initialisation radius
        /// </summary>
        private double _radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle()
        {
        }

        /// <summary>
        /// Validation radius
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательный радиус!");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Counting area for circle
        /// </summary>
        /// <returns></returns>
        public double Area
        {
            get
            {
                double area;
                area = Math.PI * _radius * _radius;
                return area;
            }
        }
    }
}
