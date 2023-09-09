namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTextBorder 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumTextBorder _i;
		internal AeccPropertyEnumTextBorder(object AeccPropertyEnumTextBorder_object) 
		{
			this._i = AeccPropertyEnumTextBorder_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumTextBorder;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccTextBorderType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
