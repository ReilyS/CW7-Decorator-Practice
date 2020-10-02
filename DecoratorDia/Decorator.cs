/*  Name: Reily Stanford
 *  Date: 10/2/2020
 *  File: Decorator.cs
 *  Description:
 *      Abstract class for Decorator that will be overwritten for different decorators of Widget.
 *      Takes a Widget and adds features to it.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDia
{
    abstract class Decorator : Widget
    {
        private Widget wid;

        public void draw()
        {
            Console.WriteLine("Drew Decorated Widget");
            wid.draw();
        }

        public Decorator(Widget w)
        {
            wid = w;
        }
    }
}
