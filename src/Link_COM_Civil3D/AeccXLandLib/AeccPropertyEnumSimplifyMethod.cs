namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSimplifyMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumSimplifyMethod _i;
		internal AeccPropertyEnumSimplifyMethod(object AeccPropertyEnumSimplifyMethod_object) 
		{
			this._i = AeccPropertyEnumSimplifyMethod_object as AeccXLandLib.IAeccPropertyEnumSimplifyMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSimplifySurfaceMethodType pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
