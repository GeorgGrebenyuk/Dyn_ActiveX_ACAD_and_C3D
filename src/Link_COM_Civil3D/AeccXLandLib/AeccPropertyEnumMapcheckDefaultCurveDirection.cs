namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultCurveDirection 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultCurveDirection _i;
		internal AeccPropertyEnumMapcheckDefaultCurveDirection(object AeccPropertyEnumMapcheckDefaultCurveDirection_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultCurveDirection_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultCurveDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccMapcheckDefaultCurveDirection pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
