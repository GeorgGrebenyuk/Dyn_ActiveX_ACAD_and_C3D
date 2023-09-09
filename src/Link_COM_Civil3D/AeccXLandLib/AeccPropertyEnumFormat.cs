namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumFormat 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumFormat _i;
		internal AeccPropertyEnumFormat(object AeccPropertyEnumFormat_object) 
		{
			this._i = AeccPropertyEnumFormat_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
