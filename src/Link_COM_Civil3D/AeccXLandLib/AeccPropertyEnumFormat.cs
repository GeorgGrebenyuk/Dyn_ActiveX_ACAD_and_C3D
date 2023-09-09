namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumFormat 
	{
		public AeccXLandLib.IAeccPropertyEnumFormat _i;
		internal AeccPropertyEnumFormat(object AeccPropertyEnumFormat_object) 
		{
			this._i = AeccPropertyEnumFormat_object as AeccXLandLib.IAeccPropertyEnumFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
