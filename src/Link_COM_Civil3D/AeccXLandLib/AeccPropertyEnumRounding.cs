namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRounding 
	{
		public AeccXLandLib.IAeccPropertyEnumRounding _i;
		internal AeccPropertyEnumRounding(object AeccPropertyEnumRounding_object) 
		{
			this._i = AeccPropertyEnumRounding_object as AeccXLandLib.IAeccPropertyEnumRounding;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccRoundingType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
