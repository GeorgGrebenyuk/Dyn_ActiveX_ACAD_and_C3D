using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
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
        ///<summary>
        ///
        ///</summary>
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

		///<summary>
		///
		///</summary>
		public object Offset(double Distance) 
		{
			return this._i.Offset(Distance);
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
