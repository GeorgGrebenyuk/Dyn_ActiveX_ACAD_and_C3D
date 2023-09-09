namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLatLongDirection 
	{
		public AeccXLandLib.IAeccPropertyEnumLatLongDirection _i;
		internal AeccPropertyEnumLatLongDirection(object AeccPropertyEnumLatLongDirection_object) 
		{
			this._i = AeccPropertyEnumLatLongDirection_object as AeccXLandLib.IAeccPropertyEnumLatLongDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccLatLongDirectionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
