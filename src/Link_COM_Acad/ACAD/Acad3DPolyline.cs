using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

    ///<summary>
    /// A 3D polyline of straight line segments
    ///</summary>
    public class Acad3DPolyline 
	{
		public Autodesk.AutoCAD.Interop.Common.Acad3DPolyline _i;
		internal Acad3DPolyline(object Acad3DPolyline_object) 
		{
			this._i = Acad3DPolyline_object as Autodesk.AutoCAD.Interop.Common.Acad3DPolyline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public Acad3DPolyline(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.Acad3DPolyline;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        /// Creates a 3D polyline from the given array of coordinates
        ///</summary>
        public Acad3DPolyline(AcadBlock AcadBlock, List<Point> VerticesList)
        {
            this._i = AcadBlock._i.Add3DPoly(Technical.PointsByDynPoints(VerticesList, true));
        }
        ///<summary>
        /// Get all cordinates in that object as array of Points
        ///</summary>
        public List<Point> Coordinates => Technical.PointsByArrayOfDoubleArray(this._i.Coordinates, false);

        ///<summary>
        /// Set coordinates to that objects from Dynamo's points array
        ///</summary>
        public void Set_Coordinates(List<Point> Coordinates)
        {
            this._i.Coordinates = Technical.PointsByDynPoints(Coordinates, false);
        }

        ///<summary>
        /// Appends a vertex to the end of a 3DPolyline
        ///</summary>
        public void AppendVertex(Point vertex) 
		{
			this._i.AppendVertex(Technical.PointByDynPoint(vertex));
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetParts(this._i.Explode());

        ///<summary>
        /// Get point by it's index from that object
        ///</summary>
        public Point Coordinate(int Index)
        {
            return Technical.PointByDynPoint(this._i.Coordinate[Index]);
        }

        ///<summary>
        /// Set point by it's index to that object
        ///</summary>
        public void Set_Coordinate(int Index, Point pVal) 
		{
            this._i.Coordinate[Index] = Technical.PointByDynPoint(pVal);
		}

        ///<summary>
        /// Specifies type of a Polyline object
        ///</summary>
        public object Type => this._i.Type;

        ///<summary>
        /// Specifies type of a Polyline object
        ///</summary>
        public void Set_Type(Autodesk.AutoCAD.Interop.Common.Ac3DPolylineType Type) 
		{
			this._i.Type = Type;
		}

        ///<summary>
        /// Specifies whether the 3D polyline is open or closed
        ///</summary>
        public bool Closed => this._i.Closed;

        ///<summary>
        /// Specifies whether the 3D polyline is open or closed
        ///</summary>
        public void Set_Closed(bool fClose) 
		{
			this._i.Closed = fClose;
		}

        ///<summary>
        /// Gets the length of an object
        ///</summary>
        public double Length => this._i.Length;
	}
}
