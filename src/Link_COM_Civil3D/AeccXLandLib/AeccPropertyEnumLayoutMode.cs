namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLayoutMode 
	{
		public AeccXLandLib.IAeccPropertyEnumLayoutMode _i;
		internal AeccPropertyEnumLayoutMode(object AeccPropertyEnumLayoutMode_object) 
		{
			this._i = AeccPropertyEnumLayoutMode_object as AeccXLandLib.IAeccPropertyEnumLayoutMode;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccLayoutModeType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
