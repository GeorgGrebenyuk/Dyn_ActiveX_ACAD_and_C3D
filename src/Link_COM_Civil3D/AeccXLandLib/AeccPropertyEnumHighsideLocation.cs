namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumHighsideLocation 
	{
		public AeccXLandLib.IAeccPropertyEnumHighsideLocation _i;
		internal AeccPropertyEnumHighsideLocation(object AeccPropertyEnumHighsideLocation_object) 
		{
			this._i = AeccPropertyEnumHighsideLocation_object as AeccXLandLib.IAeccPropertyEnumHighsideLocation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccHighsideLocationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
