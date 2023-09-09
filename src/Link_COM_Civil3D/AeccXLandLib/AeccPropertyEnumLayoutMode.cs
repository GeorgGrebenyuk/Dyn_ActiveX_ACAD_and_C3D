namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLayoutMode 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumLayoutMode _i;
		internal AeccPropertyEnumLayoutMode(object AeccPropertyEnumLayoutMode_object) 
		{
			this._i = AeccPropertyEnumLayoutMode_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumLayoutMode;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccLayoutModeType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
