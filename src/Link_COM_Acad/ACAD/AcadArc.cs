namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadArc 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadArc _i;
		internal AcadArc(object AcadArc_object) 
		{
			this._i = AcadArc_object as Autodesk.AutoCAD.Interop.Common.IAcadArc;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object StartPoint => this._i.StartPoint;

		///<summary>
		///
		///</summary>
		public object Center => this._i.Center;

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
		public object EndPoint => this._i.EndPoint;

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
