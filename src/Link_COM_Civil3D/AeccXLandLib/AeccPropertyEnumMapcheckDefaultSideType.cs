namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultSideType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultSideType _i;
		internal AeccPropertyEnumMapcheckDefaultSideType(object AeccPropertyEnumMapcheckDefaultSideType_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultSideType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultSideType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccMapcheckDefaultSideType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
