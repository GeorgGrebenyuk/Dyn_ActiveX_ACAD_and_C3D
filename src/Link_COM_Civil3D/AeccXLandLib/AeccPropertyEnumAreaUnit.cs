namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumAreaUnit 
	{
		public AeccXLandLib.IAeccPropertyEnumAreaUnit _i;
		internal AeccPropertyEnumAreaUnit(object AeccPropertyEnumAreaUnit_object) 
		{
			this._i = AeccPropertyEnumAreaUnit_object as AeccXLandLib.IAeccPropertyEnumAreaUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccAreaUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
