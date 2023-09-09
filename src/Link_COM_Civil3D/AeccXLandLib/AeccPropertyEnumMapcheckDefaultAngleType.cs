namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumMapcheckDefaultAngleType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultAngleType _i;
		internal AeccPropertyEnumMapcheckDefaultAngleType(object AeccPropertyEnumMapcheckDefaultAngleType_object) 
		{
			this._i = AeccPropertyEnumMapcheckDefaultAngleType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumMapcheckDefaultAngleType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccMapcheckDefaultAngleType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
