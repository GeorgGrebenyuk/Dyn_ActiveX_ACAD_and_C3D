namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadXline 
	{
		public AXDBLib.IAcadXline _i;
		internal AcadXline(object AcadXline_object) 
		{
			this._i = AcadXline_object as AXDBLib.IAcadXline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object BasePoint => this._i.BasePoint;

		///<summary>
		///
		///</summary>
		public void Set_BasePoint(object BasePoint) 
		{
			this._i.BasePoint = BasePoint;
		}

		///<summary>
		///
		///</summary>
		public object SecondPoint => this._i.SecondPoint;

		///<summary>
		///
		///</summary>
		public void Set_SecondPoint(object SecondPoint) 
		{
			this._i.SecondPoint = SecondPoint;
		}

		///<summary>
		///
		///</summary>
		public object DirectionVector => this._i.DirectionVector;

		///<summary>
		///
		///</summary>
		public void Set_DirectionVector(object dirVector) 
		{
			this._i.DirectionVector = dirVector;
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
