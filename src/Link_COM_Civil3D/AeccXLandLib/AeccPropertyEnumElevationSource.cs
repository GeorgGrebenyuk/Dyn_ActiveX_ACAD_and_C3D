namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumElevationSource 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumElevationSource _i;
		internal AeccPropertyEnumElevationSource(object AeccPropertyEnumElevationSource_object) 
		{
			this._i = AeccPropertyEnumElevationSource_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumElevationSource;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccElevationSourceType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
