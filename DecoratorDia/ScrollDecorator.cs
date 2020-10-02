/*  Name: Reily Stanford
 *  Date: 10/2/2020
 *  File: ScrollDecorator.cs
 *  Description:
 *      Class for ScrollDecorator that serves as a way of adding a scroll feature to a Widget.
 *      The class inherits form the Decorator class and changes the imlementation for
 *      its draw function.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDia
{
    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {
        }

        public void draw()
        {
            Console.WriteLine("Drew ScrollDecorator");
            base.draw();
        }
    }
}
