namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLocalCoordinatesType 
	{
		public AeccXLandLib.IAeccPropertyEnumLocalCoordinatesType _i;
		internal AeccPropertyEnumLocalCoordinatesType(object AeccPropertyEnumLocalCoordinatesType_object) 
		{
			this._i = AeccPropertyEnumLocalCoordinatesType_object as AeccXLandLib.IAeccPropertyEnumLocalCoordinatesType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccLocalCoordinatesType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
