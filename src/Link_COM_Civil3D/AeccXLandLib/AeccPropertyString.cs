namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyString 
	{
		public AeccXLandLib.IAeccPropertyString _i;
		internal AeccPropertyString(object AeccPropertyString_object) 
		{
			this._i = AeccPropertyString_object as AeccXLandLib.IAeccPropertyString;
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
