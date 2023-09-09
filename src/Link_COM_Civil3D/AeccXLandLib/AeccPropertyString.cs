namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyString 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyString _i;
		internal AeccPropertyString(object AeccPropertyString_object) 
		{
			this._i = AeccPropertyString_object as Autodesk.AECC.Interop.Land.IAeccPropertyString;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(string pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Value => this._i.Value;
	}
}
