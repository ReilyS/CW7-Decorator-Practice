/*  Name: Reily Stanford
 *  Date: 10/2/2020
 *  File: BorderDecorator.cs
 *  Description:
 *      Class for BorderDecorator that serves as a way of adding a border feature to a Widget.
 *      The class inherits form the Decorator class and changes the imlementation for
 *      its draw function.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDia
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {

        }

        void draw()
        {
            Console.WriteLine("Drew BorderDecorator");
            base.draw();
        }
    }
}
