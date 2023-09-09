namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTableTitleDirection 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumTableTitleDirection _i;
		internal AeccPropertyEnumTableTitleDirection(object AeccPropertyEnumTableTitleDirection_object) 
		{
			this._i = AeccPropertyEnumTableTitleDirection_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumTableTitleDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccTableTitleDirectionType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
