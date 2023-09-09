namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumTableTitleDirection 
	{
		public AeccXLandLib.IAeccPropertyEnumTableTitleDirection _i;
		internal AeccPropertyEnumTableTitleDirection(object AeccPropertyEnumTableTitleDirection_object) 
		{
			this._i = AeccPropertyEnumTableTitleDirection_object as AeccXLandLib.IAeccPropertyEnumTableTitleDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccTableTitleDirectionType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
