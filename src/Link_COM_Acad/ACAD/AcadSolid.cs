namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSolid 
	{
		public AXDBLib.IAcadSolid _i;
		internal AcadSolid(object AcadSolid_object) 
		{
			this._i = AcadSolid_object as AXDBLib.IAcadSolid;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object corners) 
		{
			this._i.Coordinates = corners;
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
		public object Coordinate(int Index) 
		{
			return this._i.Coordinate(Index);
		}

		///<summary>
		///
		///</summary>
		public void Set_Coordinate(int Index,object pVal) 
		{
			this._i.Coordinate = Index,pVal;
		}
	}
}
