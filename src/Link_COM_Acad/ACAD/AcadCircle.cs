namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadCircle 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadCircle _i;
		internal AcadCircle(object AcadCircle_object) 
		{
			this._i = AcadCircle_object as Autodesk.AutoCAD.Interop.Common.IAcadCircle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		///
		///</summary>
		public double Circumference => this._i.Circumference;

		///<summary>
		///
		///</summary>
		public void Set_Circumference(double Circumference) 
		{
			this._i.Circumference = Circumference;
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public void Set_Area(double Area) 
		{
			this._i.Area = Area;
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
	}
}
