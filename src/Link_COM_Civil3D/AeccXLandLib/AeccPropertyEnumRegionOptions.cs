namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRegionOptions 
	{
		public AeccXLandLib.IAeccPropertyEnumRegionOptions _i;
		internal AeccPropertyEnumRegionOptions(object AeccPropertyEnumRegionOptions_object) 
		{
			this._i = AeccPropertyEnumRegionOptions_object as AeccXLandLib.IAeccPropertyEnumRegionOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSimplifySurfaceRegionOptions pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
