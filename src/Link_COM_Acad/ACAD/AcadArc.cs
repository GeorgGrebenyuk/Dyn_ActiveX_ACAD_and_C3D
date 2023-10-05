using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    ///A circular arc. An arc is always drawn counterclockwise from the start point to the endpoint. The StartPoint and EndPoint properties of an arc are calculated through the StartAngle, EndAngle, and Radius properties
    ///</summary>
    public class AcadArc 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadArc _i;
		internal AcadArc(object AcadArc_object) 
		{
			this._i = AcadArc_object as Autodesk.AutoCAD.Interop.Common.AcadArc;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Try cast from AcadEntity
		/// </summary>
		/// <param name="AcadEntity"></param>
		/// <exception cref="System.Exception"></exception>
		public AcadArc(AcadEntity AcadEntity)
		{
			this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadArc;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        /// <summary>
        /// Creates an arc given the center, radius, start angle, and end angle of the arc. A start angle greater than an end angle defines a counterclockwise arc
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Center">The 3D WCS coordinates specifying the center point of the arc</param>
        /// <param name="Radius">The radius of the arc</param>
        /// <param name="StartAngle">The start, in radians, defining the arc</param>
        /// <param name="EndAngle">The send angles, in radians, defining the arc. </param>
        public AcadArc(AcadBlock AcadBlock, Point Center, double Radius, double StartAngle, double EndAngle)
        {
            this._i = AcadBlock._i.AddArc(Technical.PointByDynPoint(Center), Radius, StartAngle, EndAngle);
        }

        ///<summary>
        ///Specifies the start point
        ///</summary>
        public Point StartPoint => Technical.PointByDoubleArray(this._i.StartPoint);

        ///<summary>
        ///Specifies the center of an arc
        ///</summary>
        public Point Center => Technical.PointByDoubleArray(this._i.Center);

        ///<summary>
        ///Specifies the center of an arc
        ///</summary>
        public void Set_Center(object CenterPoint) 
		{
			this._i.Center = CenterPoint;
		}

        ///<summary>
        ///Specifies the end point
        ///</summary>
        public Point EndPoint => Technical.PointByDoubleArray(this._i.EndPoint);

        ///<summary>
        ///Specifies the radius of an arc
        ///</summary>
        public double Radius => this._i.Radius;

        ///<summary>
        ///Specifies the radius of an arc
        ///</summary>
        public void Set_Radius(double Radius) 
		{
			this._i.Radius = Radius;
		}

        ///<summary>
        ///Specifies the start angle of an arc 
        ///</summary>
        public double StartAngle => this._i.StartAngle;

        ///<summary>
        ///Specifies the start angle of an arc 
        ///</summary>
        public void Set_StartAngle(double Angle) 
		{
			this._i.StartAngle = Angle;
		}

        ///<summary>
        ///Specifies the end angle of an arc 
        ///</summary>
        public double EndAngle => this._i.EndAngle;

        ///<summary>
        ///Specifies the end angle of an arc 
        ///</summary>
        public void Set_EndAngle(double Angle) 
		{
			this._i.EndAngle = Angle;
		}

        ///<summary>
        ///Gets the total angle for the arc
        ///</summary>
        public double TotalAngle => this._i.TotalAngle;

        ///<summary>
        ///Gets the length of the arc
        ///</summary>
        public double ArcLength => this._i.ArcLength;

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
        ///Specifies the enclosed area of an arc
        ///</summary>
        public double Area => this._i.Area;

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
	}
}
