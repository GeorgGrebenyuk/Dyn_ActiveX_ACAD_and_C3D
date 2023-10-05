using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadXline 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadXline _i;
		internal AcadXline(object AcadXline_object) 
		{
			this._i = AcadXline_object as Autodesk.AutoCAD.Interop.Common.AcadXline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadXline(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadXline;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        /// Create new XLine
        ///</summary>
        public AcadXline(AcadBlock AcadBlock, Point Point1, Point Point2)
        {
            this._i =  AcadBlock._i.AddXline(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2));
        }

        ///<summary>
        ///
        ///</summary>
        public Point BasePoint => Technical.PointByDynPoint(this._i.BasePoint);

		///<summary>
		///
		///</summary>
		public void Set_BasePoint(Point BasePoint) 
		{
			this._i.BasePoint = Technical.PointByDynPoint(BasePoint);
		}

		///<summary>
		///
		///</summary>
		public Point SecondPoint => Technical.PointByDynPoint(this._i.SecondPoint);

		///<summary>
		///
		///</summary>
		public void Set_SecondPoint(Point SecondPoint) 
		{
			this._i.SecondPoint = Technical.PointByDynPoint(SecondPoint);
		}

		///<summary>
		///
		///</summary>
		public Vector DirectionVector => Technical.VectorByDoubleArray(this._i.DirectionVector);

		///<summary>
		///
		///</summary>
		public void Set_DirectionVector(Vector dirVector) 
		{
			this._i.DirectionVector = Technical.VectorByDynVector(dirVector);
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
