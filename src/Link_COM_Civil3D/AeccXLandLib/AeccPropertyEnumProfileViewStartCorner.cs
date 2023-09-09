namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewStartCorner 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewStartCorner _i;
		internal AeccPropertyEnumProfileViewStartCorner(object AeccPropertyEnumProfileViewStartCorner_object) 
		{
			this._i = AeccPropertyEnumProfileViewStartCorner_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewStartCorner;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileViewStartCornerType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
