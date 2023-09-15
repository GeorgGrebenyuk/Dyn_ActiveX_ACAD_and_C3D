using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRay 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadRay _i;
		internal AcadRay(object AcadRay_object) 
		{
			this._i = AcadRay_object as Autodesk.AutoCAD.Interop.Common.AcadRay;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadRay(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadRay;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        /// Create new Ray
        ///</summary>
        public AcadRay (AcadBlock AcadBlock, Point Point1, Point Point2)
        {
            this._i = AcadBlock._i.AddRay(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2));
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
			this._i.BasePoint = Technical.PointByDoubleArray(BasePoint);
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
			this._i.SecondPoint = Technical.PointByDoubleArray(SecondPoint);
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
			this._i.DirectionVector = Technical.VectorByDoubleArray(dirVector);
		}
	}
}
