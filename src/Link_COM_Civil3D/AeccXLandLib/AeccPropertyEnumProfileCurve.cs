namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileCurve 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileCurve _i;
		internal AeccPropertyEnumProfileCurve(object AeccPropertyEnumProfileCurve_object) 
		{
			this._i = AeccPropertyEnumProfileCurve_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileCurve;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileCurveType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
