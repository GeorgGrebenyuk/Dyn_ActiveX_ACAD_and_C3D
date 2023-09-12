using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dg = Autodesk.DesignScript.Geometry;

namespace DynAXDBLib
{
    [Autodesk.DesignScript.Runtime.IsVisibleInDynamoLibrary(false)]
    public static class Technical
    {
        public static string Exc_invalid_casting = "Invalid casting";
        public static double[] PointByDynPoint(dg.Point p)
        {
            return new double [] {  p.X, p.Y, p.Z };
        }
        public static Point PointByDoubleArray(dynamic array)
        {
            if (((double[])array).Length == 2) return Point.ByCoordinates(array[0], array[1]);
            else return Point.ByCoordinates(array[0], array[1], array[2]);
        }
    }
}
