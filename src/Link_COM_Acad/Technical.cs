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
        public static double[] PointByDynPoint(dg.Point p, bool is_planar = false)
        {
            if (!is_planar) return new double[] { p.X, p.Y, p.Z };
            else return new double[] { p.X, p.Y };

        }
        public static double[] VectorByDynVector(dg.Vector v)
        {
            return new double[] { v.X, v.Y, v.Z };
        }
        public static Point PointByDoubleArray(dynamic array)
        {
            if (((double[])array).Length == 2) return Point.ByCoordinates(array[0], array[1]);
            else return Point.ByCoordinates(array[0], array[1], array[2]);
        }
        public static Vector VectorByDoubleArray(dynamic array)
        {
            if (((double[])array).Length == 2) return Vector.ByCoordinates(array[0], array[1]);
            else return Vector.ByCoordinates(array[0], array[1], array[2]);
        }
        public static List<Point> PointsByArrayOfDoubleArray(double[] coordinates_raw, bool is_planar)
        {
            List < Point > ps = new List<Point> ();

            int coord_limit = 2;
            if (!is_planar) coord_limit = 3;
            for (int i = 0; i <= (coordinates_raw.Length - coord_limit); i+= coord_limit)
            {
                double x = coordinates_raw[i];
                double y = coordinates_raw[i + 1];
                double z = 0.0;
                if (!is_planar) z = coordinates_raw[i + 2];
                ps.Add(Point.ByCoordinates(x, y, z));
            }
            return ps;
        }
        public static double[] PointsByDynPoints(List<Point> points, bool is_planar)
        {

            double[] ps = new double[points.Count * 2];
            if (!is_planar) ps = new double[points.Count * 3];
            int counter = 0;
            foreach (var point in points)
            {
                var p = PointByDynPoint(point);
                ps[counter] = p[0];
                ps[counter + 1] = p[1];
                if (!is_planar) ps[counter + 2] = p[2];

                if (!is_planar) counter += 3;
                else counter += 2;
            }
            return ps.ToArray();
        }
        #region non_geometry
        public static List<AcadEntity> GetParts (dynamic Explode)
        {
            return ((Array)Explode).Cast<object>().Select(a=> new AcadEntity(a)).ToList();
        }
        #endregion
    }
}
