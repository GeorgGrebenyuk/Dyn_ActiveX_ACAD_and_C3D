namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumElevationSource 
	{
		public AeccXLandLib.IAeccPropertyEnumElevationSource _i;
		internal AeccPropertyEnumElevationSource(object AeccPropertyEnumElevationSource_object) 
		{
			this._i = AeccPropertyEnumElevationSource_object as AeccXLandLib.IAeccPropertyEnumElevationSource;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccElevationSourceType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
