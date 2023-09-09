namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCoordinateUnit 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumCoordinateUnit _i;
		internal AeccPropertyEnumCoordinateUnit(object AeccPropertyEnumCoordinateUnit_object) 
		{
			this._i = AeccPropertyEnumCoordinateUnit_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumCoordinateUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccCoordinateUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
