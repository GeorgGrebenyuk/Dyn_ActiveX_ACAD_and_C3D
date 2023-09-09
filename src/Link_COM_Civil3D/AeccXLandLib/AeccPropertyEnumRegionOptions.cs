namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRegionOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumRegionOptions _i;
		internal AeccPropertyEnumRegionOptions(object AeccPropertyEnumRegionOptions_object) 
		{
			this._i = AeccPropertyEnumRegionOptions_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumRegionOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccSimplifySurfaceRegionOptions pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
