namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamProfile 
	{
		public AeccXLandLib.IAeccParamProfile _i;
		internal AeccParamProfile(object AeccParamProfile_object) 
		{
			this._i = AeccParamProfile_object as AeccXLandLib.IAeccParamProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(dynamic ppVal) 
		{
			this._i.Value = ppVal;
		}
	}
}
