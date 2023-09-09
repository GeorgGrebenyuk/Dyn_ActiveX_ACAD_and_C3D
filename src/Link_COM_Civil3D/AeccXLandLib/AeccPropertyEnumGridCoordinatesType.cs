namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGridCoordinatesType 
	{
		public AeccXLandLib.IAeccPropertyEnumGridCoordinatesType _i;
		internal AeccPropertyEnumGridCoordinatesType(object AeccPropertyEnumGridCoordinatesType_object) 
		{
			this._i = AeccPropertyEnumGridCoordinatesType_object as AeccXLandLib.IAeccPropertyEnumGridCoordinatesType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccGridCoordinatesType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
