namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyBoolean 
	{
		public AeccXLandLib.IAeccPropertyBoolean _i;
		internal AeccPropertyBoolean(object AeccPropertyBoolean_object) 
		{
			this._i = AeccPropertyBoolean_object as AeccXLandLib.IAeccPropertyBoolean;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(bool pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Value => this._i.Value;
	}
}
