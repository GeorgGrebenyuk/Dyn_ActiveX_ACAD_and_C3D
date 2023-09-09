namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultCurveDirection 
	{
		public AeccXLandLib.IAeccPropertyEnumMapcheckDefaultCurveDirection _i;
		internal AeccPropertyEnumMapcheckDefaultCurveDirection(object AeccPropertyEnumMapcheckDefaultCurveDirection_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultCurveDirection_object as AeccXLandLib.IAeccPropertyEnumMapcheckDefaultCurveDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccMapcheckDefaultCurveDirection pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
