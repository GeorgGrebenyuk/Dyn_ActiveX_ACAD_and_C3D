namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSlopeFormat 
	{
		public AeccXLandLib.IAeccPropertyEnumSlopeFormat _i;
		internal AeccPropertyEnumSlopeFormat(object AeccPropertyEnumSlopeFormat_object) 
		{
			this._i = AeccPropertyEnumSlopeFormat_object as AeccXLandLib.IAeccPropertyEnumSlopeFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSlopeFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
