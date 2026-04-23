using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //class Color {byte red; byte green; byte blue; byte alpha}
            Spheres redsphere = new Spheres(new Color(255,0,0), 1f); 
            Spheres greensphere = new Spheres(new Color(0,255,0), 1.0f);
            Spheres bluesphere = new Spheres(new Color(0,0,255), 1.0f);
            bluesphere.PrintInfo();
            bluesphere.Throw();
            bluesphere.Throw();
            bluesphere.Throw();
            bluesphere.Throw();
            bluesphere.Throw(); 

            greensphere.PrintInfo();
            greensphere.Pop();
            greensphere.Throw();
            
            redsphere.PrintInfo();
            redsphere.Throw();
            redsphere.Pop();
            redsphere.Throw();

            Spheres[] spheres = {redsphere, greensphere, bluesphere};
            
/*
            foreach (Spheres sphere in spheres)
            {
                sphere.Throw();
                //Console.WriteLine($"State of the ball:\nThrown: {sphere.GetTimesThrown()},");
                Console.WriteLine($"Color of the ball: {sphere._color}");
            }
*/
            //Console.WriteLine(GetTimesThrown());
            /*foreach (Spheres sphere in spheres)
            {
                if sphere.Pop = true;
            }
            */

        }
    }
    class Color
        {
            private byte _red;
            private byte _green;
            private byte _blue;
            private int _alpha;
        

        public Color(byte r, byte g, byte b, int a)
        {
            _red = r;
            _green = g;
            _blue = b;
            _alpha = GetGrey();
            //alpha = a;
        } 

        public Color(byte r, byte g, byte b)
        {
            _red = r;
            _green = g;
            _blue = b;
            _alpha = 255;
        }

        public byte GetRed() => _red;
        public byte GetBlue() => _blue;
        public byte GetGreen() => _green;
        public int GetGrey() => (_red + _blue + _green) / 3;
        //{
            //red + blue + green / 3;
            //int red = Convert.ToInt32()

        public override string ToString()
{
    return $"R:{_red}, G:{_green}, B:{_blue}";
}
        }
        



    class Spheres
    {
        //private int color
        public Color _color;
        private float _radius;
        private int _numTimesThrownBall;
        //private bool _popped;

        public void PrintInfo()
        {
        
            Console.WriteLine($"\nState of the ball:\nThrown: {GetTimesThrown()},");
            Console.WriteLine($"Color of the ball: {_color}");

        }

        public Spheres(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _numTimesThrownBall = GetNumTimesThrownBall();
            
        }

        private int GetNumTimesThrownBall()
        {
            return 0;
            //return Convert.ToInt32(Console.ReadLine());
        }

        public void Pop()
        {
            _radius = 0;
            //_popped = true;
            Console.WriteLine($"{_color} ball was popped");
        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _numTimesThrownBall += 1;
            }

        }

        public int GetTimesThrown() => _numTimesThrownBall;
        
    }


}
