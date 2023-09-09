namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCatchmentObjectType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumCatchmentObjectType _i;
		internal AeccPropertyEnumCatchmentObjectType(object AeccPropertyEnumCatchmentObjectType_object) 
		{
			this._i = AeccPropertyEnumCatchmentObjectType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumCatchmentObjectType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccCatchmentObjectType pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
