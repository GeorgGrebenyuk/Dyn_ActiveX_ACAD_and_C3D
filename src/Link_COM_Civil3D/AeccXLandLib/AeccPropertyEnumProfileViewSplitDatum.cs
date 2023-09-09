namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewSplitDatum 
	{
		public AeccXLandLib.IAeccPropertyEnumProfileViewSplitDatum _i;
		internal AeccPropertyEnumProfileViewSplitDatum(object AeccPropertyEnumProfileViewSplitDatum_object) 
		{
			this._i = AeccPropertyEnumProfileViewSplitDatum_object as AeccXLandLib.IAeccPropertyEnumProfileViewSplitDatum;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccProfileViewSplitDatumType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
