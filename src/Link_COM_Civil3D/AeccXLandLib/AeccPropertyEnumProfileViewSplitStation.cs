namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewSplitStation 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewSplitStation _i;
		internal AeccPropertyEnumProfileViewSplitStation(object AeccPropertyEnumProfileViewSplitStation_object) 
		{
			this._i = AeccPropertyEnumProfileViewSplitStation_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewSplitStation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileViewSplitStationType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
