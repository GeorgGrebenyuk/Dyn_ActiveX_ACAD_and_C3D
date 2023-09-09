namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTextBorder 
	{
		public AeccXLandLib.IAeccPropertyEnumTextBorder _i;
		internal AeccPropertyEnumTextBorder(object AeccPropertyEnumTextBorder_object) 
		{
			this._i = AeccPropertyEnumTextBorder_object as AeccXLandLib.IAeccPropertyEnumTextBorder;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccTextBorderType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
