using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extended_methods.Model
{
    internal class Point
    {
        public float X { get; set; }
        public float Y { get; set; }


        //porownywanie wartosci referencyjnych
        public static bool operator ==(Point left, Point right) { 
            return Equals(left, right);
        }

        public static bool operator !=(Point left, Point right) { 
            return !Equals(left, right);
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(this.GetType() != obj.GetType()) return false;

            Point other = (Point)obj;

            return this.X==other.X && this.Y==other.Y;  
        }
    }
}
