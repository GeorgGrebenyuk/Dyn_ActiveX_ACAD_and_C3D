namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCorridorType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumCorridorType _i;
		internal AeccPropertyEnumCorridorType(object AeccPropertyEnumCorridorType_object) 
		{
			this._i = AeccPropertyEnumCorridorType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumCorridorType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccCorridorType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
