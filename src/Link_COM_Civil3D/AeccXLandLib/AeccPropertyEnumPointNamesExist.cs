namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointNamesExist 
	{
		public AeccXLandLib.IAeccPropertyEnumPointNamesExist _i;
		internal AeccPropertyEnumPointNamesExist(object AeccPropertyEnumPointNamesExist_object) 
		{
			this._i = AeccPropertyEnumPointNamesExist_object as AeccXLandLib.IAeccPropertyEnumPointNamesExist;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPointNamesExistType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
