namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointNumbersExist 
	{
		public AeccXLandLib.IAeccPropertyEnumPointNumbersExist _i;
		internal AeccPropertyEnumPointNumbersExist(object AeccPropertyEnumPointNumbersExist_object) 
		{
			this._i = AeccPropertyEnumPointNumbersExist_object as AeccXLandLib.IAeccPropertyEnumPointNumbersExist;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPointNumbersExistType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
