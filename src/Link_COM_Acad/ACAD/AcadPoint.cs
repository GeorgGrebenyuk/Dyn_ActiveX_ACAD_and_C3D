using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// A point marker appearing as a dot, square, circle, X, tick, or plus sign (+); or as a combination of these
    ///</summary>
    public class AcadPoint 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPoint _i;
		internal AcadPoint(object AcadPoint_object) 
		{
			this._i = AcadPoint_object as Autodesk.AutoCAD.Interop.Common.AcadPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadPoint(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadPoint;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }


        /// <summary>
        /// Creates a Point object at a given location
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Point">The coordinates of the point to be created</param>
        public AcadPoint(AcadBlock AcadBlock, Point Point)
        {
            this._i = AcadBlock._i.AddPoint(Technical.PointByDynPoint(Point));
        }


        ///<summary>
        /// Get all cordinates in that object as array of Points
        ///</summary>
        public Point Coordinates => Technical.PointByDoubleArray(this._i.Coordinates);

        ///<summary>
        /// Set coordinates to that objects from Dynamo's points array
        ///</summary>
        public void Set_Coordinates(Point Coordinates)
        {
            this._i.Coordinates = Technical.PointByDynPoint(Coordinates);
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
    }
}
