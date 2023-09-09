namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGradeSlopeFormat 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumGradeSlopeFormat _i;
		internal AeccPropertyEnumGradeSlopeFormat(object AeccPropertyEnumGradeSlopeFormat_object) 
		{
			this._i = AeccPropertyEnumGradeSlopeFormat_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumGradeSlopeFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccGradeSlopeFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
