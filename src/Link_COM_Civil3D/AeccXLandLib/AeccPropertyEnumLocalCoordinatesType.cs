namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLocalCoordinatesType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumLocalCoordinatesType _i;
		internal AeccPropertyEnumLocalCoordinatesType(object AeccPropertyEnumLocalCoordinatesType_object) 
		{
			this._i = AeccPropertyEnumLocalCoordinatesType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumLocalCoordinatesType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccLocalCoordinatesType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
