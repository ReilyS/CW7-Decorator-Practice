/*  Name: Reily Stanford
 *  Date: 10/2/2020
 *  File: DecoratorDemo.cs
 *  Description:
 *      Main Driver for the Decorator Structural Design Pattern for a TextField
 *      This file creates and calls the draw functions of the Widget called TextField
 *      and its decorators.
 */
using System;

namespace DecoratorDia
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TextField");
            Widget textField = new TextField(3, 4);
            textField.draw();
            Console.WriteLine("\nScrollDecorator");
            ScrollDecorator scroll = new ScrollDecorator(textField);
            scroll.draw();
            Console.WriteLine("\nBorderDecorator");
            BorderDecorator border = new BorderDecorator(textField);
            border.draw();
            Console.WriteLine("\nZoomDecorator");
            ZoomDecorator zoom = new ZoomDecorator(textField);
            zoom.draw();
        }
    }
}
