﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if(value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Длинна не может быть отрицательной или равной 0");
                }
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Ширина не может быть отрицательной или равной 0");
                }
            }
        }
        public string Color { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}