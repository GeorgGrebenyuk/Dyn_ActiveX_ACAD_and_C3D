namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumAnchorLocation 
	{
		public AeccXLandLib.IAeccPropertyEnumAnchorLocation _i;
		internal AeccPropertyEnumAnchorLocation(object AeccPropertyEnumAnchorLocation_object) 
		{
			this._i = AeccPropertyEnumAnchorLocation_object as AeccXLandLib.IAeccPropertyEnumAnchorLocation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccAnchorLocationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
