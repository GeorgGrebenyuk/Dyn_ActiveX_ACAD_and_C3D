namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSlopeFormat 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumSlopeFormat _i;
		internal AeccPropertyEnumSlopeFormat(object AeccPropertyEnumSlopeFormat_object) 
		{
			this._i = AeccPropertyEnumSlopeFormat_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumSlopeFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccSlopeFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
