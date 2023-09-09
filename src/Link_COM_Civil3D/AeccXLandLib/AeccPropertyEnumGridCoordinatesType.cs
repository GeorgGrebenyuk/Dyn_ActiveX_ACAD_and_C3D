namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumGridCoordinatesType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumGridCoordinatesType _i;
		internal AeccPropertyEnumGridCoordinatesType(object AeccPropertyEnumGridCoordinatesType_object) 
		{
			this._i = AeccPropertyEnumGridCoordinatesType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumGridCoordinatesType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccGridCoordinatesType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
