namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGeoCoordinatesType 
	{
		public AeccXLandLib.IAeccPropertyEnumGeoCoordinatesType _i;
		internal AeccPropertyEnumGeoCoordinatesType(object AeccPropertyEnumGeoCoordinatesType_object) 
		{
			this._i = AeccPropertyEnumGeoCoordinatesType_object as AeccXLandLib.IAeccPropertyEnumGeoCoordinatesType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccGeoCoordinatesType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
