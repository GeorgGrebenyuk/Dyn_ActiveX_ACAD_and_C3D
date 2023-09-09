namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultCurveTraverseMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumMapcheckDefaultCurveTraverseMethod _i;
		internal AeccPropertyEnumMapcheckDefaultCurveTraverseMethod(object AeccPropertyEnumMapcheckDefaultCurveTraverseMethod_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultCurveTraverseMethod_object as AeccXLandLib.IAeccPropertyEnumMapcheckDefaultCurveTraverseMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccMapcheckDefaultCurveTraverseMethod pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
