namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLine 
	{
		public AXDBLib.IAcadLine _i;
		internal AcadLine(object AcadLine_object) 
		{
			this._i = AcadLine_object as AXDBLib.IAcadLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object StartPoint => this._i.StartPoint;

		///<summary>
		///
		///</summary>
		public void Set_StartPoint(object StartPoint) 
		{
			this._i.StartPoint = StartPoint;
		}

		///<summary>
		///
		///</summary>
		public object EndPoint => this._i.EndPoint;

		///<summary>
		///
		///</summary>
		public void Set_EndPoint(object EndPoint) 
		{
			this._i.EndPoint = EndPoint;
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
