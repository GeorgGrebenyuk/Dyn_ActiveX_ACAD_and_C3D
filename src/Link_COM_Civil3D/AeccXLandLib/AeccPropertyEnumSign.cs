namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSign 
	{
		public AeccXLandLib.IAeccPropertyEnumSign _i;
		internal AeccPropertyEnumSign(object AeccPropertyEnumSign_object) 
		{
			this._i = AeccPropertyEnumSign_object as AeccXLandLib.IAeccPropertyEnumSign;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSignType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
