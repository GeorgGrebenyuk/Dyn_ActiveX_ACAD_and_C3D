namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyColor 
	{
		public AeccXLandLib.IAeccPropertyColor _i;
		internal AeccPropertyColor(object AeccPropertyColor_object) 
		{
			this._i = AeccPropertyColor_object as AeccXLandLib.IAeccPropertyColor;
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
