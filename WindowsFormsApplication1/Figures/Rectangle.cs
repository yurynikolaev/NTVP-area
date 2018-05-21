using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Figures
{
    /// <summary>
    /// Rectangle class
    /// </summary>
    public class Rectangle : IFigure
    {
        /// <summary>
        /// Initialisation width
        /// </summary>
        private double _width;
        /// <summary>
        /// Initialisation height
        /// </summary>
        private double _height;

        public Rectangle(double _width, double _height)
        {
            this._width = _width;
            this._height = _height;
        }

        public Rectangle()
        {
        }

        //private IFigure _figureImplementation;

        /// <summary>
        /// Validation width
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательная ширина!");
                }
                _width = value;
            }
        }
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
        /// Counting rectangle's area 
        /// </summary>
        /// <returns></returns>
        public double Area
        {
            get
            {
                double area;
                area = _width * _height;
                return area;
            }
        }

        //double IFigure.Area
        //{
        //    get { return _figureImplementation.Area; }
        //    set { _figureImplementation.Area = value; }
        //}
    }
}
