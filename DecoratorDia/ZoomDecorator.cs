/*  Name: Reily Stanford
 *  Date: 10/2/2020
 *  File: ScrollDecorator.cs
 *  Description:
 *      Class for ZoomDecorator that serves as a way of adding a zoom feature to a Widget.
 *      The class inherits form the Decorator class and changes the imlementation for
 *      its draw function.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDia
{
    class ZoomDecorator : Decorator
    {
        public ZoomDecorator(Widget w) : base(w)
        {
            
        }

        void draw()
        {
            Console.WriteLine("Drew ZoomDecorator");
            base.draw();
        }
    }
}
