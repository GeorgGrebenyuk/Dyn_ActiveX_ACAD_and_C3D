namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumAreaUnit 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumAreaUnit _i;
		internal AeccPropertyEnumAreaUnit(object AeccPropertyEnumAreaUnit_object) 
		{
			this._i = AeccPropertyEnumAreaUnit_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumAreaUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccAreaUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
