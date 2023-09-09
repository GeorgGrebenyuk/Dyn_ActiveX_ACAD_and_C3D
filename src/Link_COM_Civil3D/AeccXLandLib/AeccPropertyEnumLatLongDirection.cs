namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLatLongDirection 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumLatLongDirection _i;
		internal AeccPropertyEnumLatLongDirection(object AeccPropertyEnumLatLongDirection_object) 
		{
			this._i = AeccPropertyEnumLatLongDirection_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumLatLongDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccLatLongDirectionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
