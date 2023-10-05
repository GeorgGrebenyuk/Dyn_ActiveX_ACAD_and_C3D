using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace DynAXDBLib 
{

    ///<summary>
    /// A 2D line with adjustable width composed of line and arc segments
    ///</summary>
    public class AcadLWPolyline 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLWPolyline _i;
		internal AcadLWPolyline(object AcadLWPolyline_object) 
		{
			this._i = AcadLWPolyline_object as Autodesk.AutoCAD.Interop.Common.AcadLWPolyline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadLWPolyline(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadLWPolyline;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
        /// Creates a lightweight polyline from a list of vertices
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="VerticesList">Array on vertices</param>
        public AcadLWPolyline(AcadBlock AcadBlock, List<Point> VerticesList)
        {
            this._i = AcadBlock._i.AddLightWeightPolyline(Technical.PointsByDynPoints(VerticesList, true));
        }
        ///<summary>
        /// Get all cordinates in that object as array of Points
        ///</summary>
        public List<Point> Coordinates => Technical.PointsByArrayOfDoubleArray(this._i.Coordinates, true);

        ///<summary>
        /// Set coordinates to that objects from Dynamo's points array
        ///</summary>
        public void Set_Coordinates(List<Point> Coordinates)
        {
            this._i.Coordinates = Technical.PointsByDynPoints(Coordinates, true);
        }

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
        }

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public double Thickness => this._i.Thickness;

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public void Set_Thickness(double Thickness)
        {
            this._i.Thickness = Thickness;
        }

        ///<summary>
        ///
        ///</summary>
        public void AddVertex(int Index, Point vertex) 
		{
			this._i.AddVertex(Index,Technical.PointByDynPoint(vertex, true));
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetParts(this._i.Explode());

		///<summary>
		///
		///</summary>
		public double GetBulge(int Index) 
		{
			return this._i.GetBulge(Index);
		}

		///<summary>
		///
		///</summary>
		public void SetBulge(int Index,double bulge) 
		{
			this._i.SetBulge(Index,bulge);
		}

		///<summary>
		///
		///</summary>
		public List<double> GetWidth(int Index)
        {
			double StartWidth;
			double EndWidth;

            this._i.GetWidth(Index,out StartWidth,out EndWidth);
			return new List<double> { StartWidth, EndWidth };
		}

		///<summary>
		///
		///</summary>
		public void SetWidth(int Index,double StartWidth,double EndWidth) 
		{
			this._i.SetWidth(Index,StartWidth,EndWidth);
		}

		///<summary>
		///
		///</summary>
		public double ConstantWidth => this._i.ConstantWidth;

		///<summary>
		///
		///</summary>
		public void Set_ConstantWidth(double Width) 
		{
			this._i.ConstantWidth = Width;
		}

        /// <summary>
        /// Creates a new object at a specified offset distance from an existing object
        /// </summary>
        /// <param name="Distance">The distance to offset the object. The offset can be a positive or negative number, but it cannot equal zero. If the offset is negative, this is interpreted as being an offset to make a "smaller" curve (that is, for an arc it would offset to a radius that is "Distance less" than the starting curve's radius). If "smaller" has no meaning, then it would offset in the direction of smaller X, Y, and Z WCS coordinates</param>
        /// <returns></returns>
        public List<AcadEntity> Offset(double Distance)
        {
            return Technical.GetParts(this._i.Offset(Distance));
        }

        ///<summary>
        ///
        ///</summary>
        public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double Elevation) 
		{
			this._i.Elevation = Elevation;
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

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
            this._i.Coordinate[Index] = Technical.PointByDynPoint(pVal, true);
        }

        ///<summary>
        ///
        ///</summary>
        public bool Closed => this._i.Closed;

		///<summary>
		///
		///</summary>
		public void Set_Closed(bool fClose) 
		{
			this._i.Closed = fClose;
		}

		///<summary>
		///
		///</summary>
		public bool LinetypeGeneration => this._i.LinetypeGeneration;

		///<summary>
		///
		///</summary>
		public void Set_LinetypeGeneration(bool bLinetypeGen) 
		{
			this._i.LinetypeGeneration = bLinetypeGen;
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;
	}
}
