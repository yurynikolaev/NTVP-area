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
    public class Rectangle
    {
        /// <summary>
        /// Initialisation width
        /// </summary>
        private double _width;
        /// <summary>
        /// Initialisation height
        /// </summary>
        private double _height;
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
        public double GetArea()
        {
            double area;
            area = _width * _height;
            return area;
        }
    }
}
