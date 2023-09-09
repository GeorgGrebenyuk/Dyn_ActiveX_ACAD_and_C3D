namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGradeFormat 
	{
		public AeccXLandLib.IAeccPropertyEnumGradeFormat _i;
		internal AeccPropertyEnumGradeFormat(object AeccPropertyEnumGradeFormat_object) 
		{
			this._i = AeccPropertyEnumGradeFormat_object as AeccXLandLib.IAeccPropertyEnumGradeFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccGradeFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
