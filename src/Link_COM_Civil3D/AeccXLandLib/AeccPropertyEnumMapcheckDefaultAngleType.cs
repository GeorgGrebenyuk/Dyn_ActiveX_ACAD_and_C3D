namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultAngleType 
	{
		public AeccXLandLib.IAeccPropertyEnumMapcheckDefaultAngleType _i;
		internal AeccPropertyEnumMapcheckDefaultAngleType(object AeccPropertyEnumMapcheckDefaultAngleType_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultAngleType_object as AeccXLandLib.IAeccPropertyEnumMapcheckDefaultAngleType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccMapcheckDefaultAngleType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
