namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPlottedTextDisplay 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumPlottedTextDisplay _i;
		internal AeccPropertyEnumPlottedTextDisplay(object AeccPropertyEnumPlottedTextDisplay_object) 
		{
			this._i = AeccPropertyEnumPlottedTextDisplay_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumPlottedTextDisplay;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccPlottedTextDisplayType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
