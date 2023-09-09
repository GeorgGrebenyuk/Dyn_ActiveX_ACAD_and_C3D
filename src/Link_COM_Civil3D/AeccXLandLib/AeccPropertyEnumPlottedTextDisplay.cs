namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPlottedTextDisplay 
	{
		public AeccXLandLib.IAeccPropertyEnumPlottedTextDisplay _i;
		internal AeccPropertyEnumPlottedTextDisplay(object AeccPropertyEnumPlottedTextDisplay_object) 
		{
			this._i = AeccPropertyEnumPlottedTextDisplay_object as AeccXLandLib.IAeccPropertyEnumPlottedTextDisplay;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPlottedTextDisplayType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
