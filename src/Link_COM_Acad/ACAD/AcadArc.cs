using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
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
        ///<summary>
        ///Create new Arc
        ///</summary>
        public AcadArc(AcadBlock AcadBlock, Point Center, double Radius, double StartAngle, double EndAngle)
        {
            this._i = AcadBlock._i.AddArc(Technical.PointByDynPoint(Center), Radius, StartAngle, EndAngle);
        }

        ///<summary>
        ///
        ///</summary>
        public Point StartPoint => Technical.PointByDoubleArray(this._i.StartPoint);

		///<summary>
		///
		///</summary>
		public Point Center => Technical.PointByDoubleArray(this._i.Center);

		///<summary>
		///
		///</summary>
		public void Set_Center(object CenterPoint) 
		{
			this._i.Center = CenterPoint;
		}

		///<summary>
		///
		///</summary>
		public Point EndPoint => Technical.PointByDoubleArray(this._i.EndPoint);

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
		public double StartAngle => this._i.StartAngle;

		///<summary>
		///
		///</summary>
		public void Set_StartAngle(dynamic Angle) 
		{
			this._i.StartAngle = Angle;
		}

		///<summary>
		///
		///</summary>
		public double EndAngle => this._i.EndAngle;

		///<summary>
		///
		///</summary>
		public void Set_EndAngle(double Angle) 
		{
			this._i.EndAngle = Angle;
		}

		///<summary>
		///
		///</summary>
		public double TotalAngle => this._i.TotalAngle;

		///<summary>
		///
		///</summary>
		public double ArcLength => this._i.ArcLength;

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
		public double Area => this._i.Area;

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
	}
}
