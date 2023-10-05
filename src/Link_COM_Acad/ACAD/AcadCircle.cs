using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    ///A full circle
    ///</summary>
    public class AcadCircle 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadCircle _i;
		internal AcadCircle(object AcadCircle_object) 
		{
			this._i = AcadCircle_object as Autodesk.AutoCAD.Interop.Common.AcadCircle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadCircle(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadCircle;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
        /// Creates a circle given a center point and radius
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Center">The 3D WCS coordinates specifying the circle's center</param>
        /// <param name="Radius">The radius of the circle. Must be a positive number</param>
        public AcadCircle (AcadBlock AcadBlock, Point Center, double Radius)
        {
            this._i = AcadBlock._i.AddCircle(Technical.PointByDynPoint(Center), Radius);
        }

        ///<summary>
        ///Specifies the center of circle
        ///</summary>
        public Point Center => Technical.PointByDoubleArray(this._i.Center);

        ///<summary>
        ///Specifies the center of circle
        ///</summary>
        public void Set_Center(Point CenterPoint) 
		{
			this._i.Center = Technical.PointByDynPoint(CenterPoint);
		}

		///<summary>
		///
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public void Set_Radius(double Radius) 
		{
			this._i.Radius = Radius;
		}

		///<summary>
		///
		///</summary>
		public double Diameter => this._i.Diameter;

		///<summary>
		///
		///</summary>
		public void Set_Diameter(double Diameter) 
		{
			this._i.Diameter = Diameter;
		}

        ///<summary>
        ///Specifies the circumference of a circle
        ///</summary>
        public double Circumference => this._i.Circumference;

        ///<summary>
        ///Specifies the circumference of a circle
        ///</summary>
        public void Set_Circumference(double Circumference) 
		{
			this._i.Circumference = Circumference;
		}

        ///<summary>
        ///Specifies the enclosed area of circle
        ///</summary>
        public double Area => this._i.Area;

        ///<summary>
        ///Specifies the enclosed area of an circle
        ///</summary>
        public void Set_Area(double Area) 
		{
			this._i.Area = Area;
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
    }
}
