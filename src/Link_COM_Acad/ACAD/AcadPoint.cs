using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
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


        ///<summary>
        ///
        ///</summary>
        public AcadPoint(AcadBlock AcadBlock, Point Point)
        {
            this._i = AcadBlock._i.AddPoint(Technical.PointByDynPoint(Point));
        }


        ///<summary>
        ///
        ///</summary>
        public Point Coordinates => Technical.PointByDoubleArray(this._i.Coordinates);

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(Point Coordinates) 
		{
			this._i.Coordinates = Technical.PointByDynPoint(Coordinates);
		}

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public double Thickness => this._i.Thickness;

		///<summary>
		///
		///</summary>
		public void Set_Thickness(double Thickness) 
		{
			this._i.Thickness = Thickness;
		}
	}
}
