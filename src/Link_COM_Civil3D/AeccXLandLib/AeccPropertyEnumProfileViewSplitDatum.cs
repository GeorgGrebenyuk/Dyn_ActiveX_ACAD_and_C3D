namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewSplitDatum 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewSplitDatum _i;
		internal AeccPropertyEnumProfileViewSplitDatum(object AeccPropertyEnumProfileViewSplitDatum_object) 
		{
			this._i = AeccPropertyEnumProfileViewSplitDatum_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewSplitDatum;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileViewSplitDatumType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
