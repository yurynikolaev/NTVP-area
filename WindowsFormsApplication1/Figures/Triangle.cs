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
    public class Triangle : IFigure
    {
        /// <summary>
        /// Initialisation height
        /// </summary>
        private double _height;
        /// <summary>
        /// Initialization catet
        /// </summary>
        private double _catet;

        public Triangle(double _height, double _catet)
        {
            this._height = _height;
            this._catet = _catet;
        }

        public Triangle()
        {
        }

        //private IFigure _figureImplementation;

        //private IFigure _figureImplementation;
        //private IFigure _figureImplementation1;

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
        public double Area
        {
            get
            {
                double area;
                area = 0.5 * _catet * _height;
                return area;
            }
        }
    }
}
