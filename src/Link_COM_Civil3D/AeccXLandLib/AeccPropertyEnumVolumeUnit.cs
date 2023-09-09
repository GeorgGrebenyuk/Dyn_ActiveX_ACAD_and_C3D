namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumVolumeUnit 
	{
		public AeccXLandLib.IAeccPropertyEnumVolumeUnit _i;
		internal AeccPropertyEnumVolumeUnit(object AeccPropertyEnumVolumeUnit_object) 
		{
			this._i = AeccPropertyEnumVolumeUnit_object as AeccXLandLib.IAeccPropertyEnumVolumeUnit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccVolumeUnitType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
