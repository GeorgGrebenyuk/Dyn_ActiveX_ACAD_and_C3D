using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// A single line segment
    ///</summary>
    public class AcadLine 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLine _i;
		internal AcadLine(object AcadLine_object) 
		{
			this._i = AcadLine_object as Autodesk.AutoCAD.Interop.Common.AcadLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadLine(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadLine;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
        /// Creates a line passing through two points
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="StartPoint">The 3D WCS coordinates specifying the line start point</param>
        /// <param name="EndPoint">The 3D WCS coordinates specifying the line endpoint</param>
        public AcadLine(AcadBlock AcadBlock, Point StartPoint, Point EndPoint)
        {
            this._i =  AcadBlock._i.AddLine(Technical.PointByDynPoint(StartPoint), Technical.PointByDynPoint(EndPoint));
        }

        ///<summary>
        ///
        ///</summary>
        public Point StartPoint => Technical.PointByDoubleArray(this._i.StartPoint);

		///<summary>
		///
		///</summary>
		public void Set_StartPoint(Point StartPoint) 
		{
			this._i.StartPoint = Technical.PointByDynPoint(StartPoint);
		}

		///<summary>
		///
		///</summary>
		public Point EndPoint => Technical.PointByDoubleArray(this._i.EndPoint);

		///<summary>
		///
		///</summary>
		public void Set_EndPoint(Point EndPoint) 
		{
			this._i.EndPoint = Technical.PointByDynPoint(EndPoint);
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
        public object Delta => this._i.Delta;

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public dynamic Angle => this._i.Angle;
	}
}
