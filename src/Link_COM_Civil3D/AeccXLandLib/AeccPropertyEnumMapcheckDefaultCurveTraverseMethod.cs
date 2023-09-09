namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultCurveTraverseMethod 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultCurveTraverseMethod _i;
		internal AeccPropertyEnumMapcheckDefaultCurveTraverseMethod(object AeccPropertyEnumMapcheckDefaultCurveTraverseMethod_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultCurveTraverseMethod_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultCurveTraverseMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccMapcheckDefaultCurveTraverseMethod pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
