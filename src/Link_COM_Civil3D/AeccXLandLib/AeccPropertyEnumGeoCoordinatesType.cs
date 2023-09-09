namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGeoCoordinatesType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumGeoCoordinatesType _i;
		internal AeccPropertyEnumGeoCoordinatesType(object AeccPropertyEnumGeoCoordinatesType_object) 
		{
			this._i = AeccPropertyEnumGeoCoordinatesType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumGeoCoordinatesType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccGeoCoordinatesType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
