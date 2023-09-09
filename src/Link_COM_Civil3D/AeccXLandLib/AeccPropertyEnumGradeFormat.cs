namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGradeFormat 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumGradeFormat _i;
		internal AeccPropertyEnumGradeFormat(object AeccPropertyEnumGradeFormat_object) 
		{
			this._i = AeccPropertyEnumGradeFormat_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumGradeFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccGradeFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
