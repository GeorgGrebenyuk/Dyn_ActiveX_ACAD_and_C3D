namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCapitalization 
	{
		public AeccXLandLib.IAeccPropertyEnumCapitalization _i;
		internal AeccPropertyEnumCapitalization(object AeccPropertyEnumCapitalization_object) 
		{
			this._i = AeccPropertyEnumCapitalization_object as AeccXLandLib.IAeccPropertyEnumCapitalization;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccCapitalizationType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
