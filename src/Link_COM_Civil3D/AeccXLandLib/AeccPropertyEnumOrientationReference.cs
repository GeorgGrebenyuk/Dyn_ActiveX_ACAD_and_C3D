namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumOrientationReference 
	{
		public AeccXLandLib.IAeccPropertyEnumOrientationReference _i;
		internal AeccPropertyEnumOrientationReference(object AeccPropertyEnumOrientationReference_object) 
		{
			this._i = AeccPropertyEnumOrientationReference_object as AeccXLandLib.IAeccPropertyEnumOrientationReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccOrientationReferenceType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
