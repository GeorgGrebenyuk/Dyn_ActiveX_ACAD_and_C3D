namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPathObjectType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumPathObjectType _i;
		internal AeccPropertyEnumPathObjectType(object AeccPropertyEnumPathObjectType_object) 
		{
			this._i = AeccPropertyEnumPathObjectType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumPathObjectType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccPathObjectType pValue) 
		{
			this._i.Value = pValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
