namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumAngleUnit 
	{
		public AeccXLandLib.IAeccPropertyEnumAngleUnit _i;
		internal AeccPropertyEnumAngleUnit(object AeccPropertyEnumAngleUnit_object) 
		{
			this._i = AeccPropertyEnumAngleUnit_object as AeccXLandLib.IAeccPropertyEnumAngleUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccAngleUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
