namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyLong 
	{
		public AeccXLandLib.IAeccPropertyLong _i;
		internal AeccPropertyLong(object AeccPropertyLong_object) 
		{
			this._i = AeccPropertyLong_object as AeccXLandLib.IAeccPropertyLong;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(dynamic pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
