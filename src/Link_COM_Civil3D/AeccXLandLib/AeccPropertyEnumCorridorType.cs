namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCorridorType 
	{
		public AeccXLandLib.IAeccPropertyEnumCorridorType _i;
		internal AeccPropertyEnumCorridorType(object AeccPropertyEnumCorridorType_object) 
		{
			this._i = AeccPropertyEnumCorridorType_object as AeccXLandLib.IAeccPropertyEnumCorridorType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccCorridorType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
