/*  Name: Reily Stanford
 *  Date: 10/2/2020
 *  File: TextField.cs
 *  Description:
 *     Class for a TextField object that inherits from the Widget Interface and imlements its draw function
 *     This class also has the TextField dimensions and has a constructor to set those dimensions
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDia
{
    class TextField : Widget
    {
        private int width;
        private int height;

        public void draw()
        {
            Console.WriteLine($"Drew a {width} x {height} TextField");
        }

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }
    }
}
