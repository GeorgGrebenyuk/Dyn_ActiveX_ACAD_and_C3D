namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPathObjectType 
	{
		public AeccXLandLib.IAeccPropertyEnumPathObjectType _i;
		internal AeccPropertyEnumPathObjectType(object AeccPropertyEnumPathObjectType_object) 
		{
			this._i = AeccPropertyEnumPathObjectType_object as AeccXLandLib.IAeccPropertyEnumPathObjectType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPathObjectType pValue) 
		{
			this._i.Value = pValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
