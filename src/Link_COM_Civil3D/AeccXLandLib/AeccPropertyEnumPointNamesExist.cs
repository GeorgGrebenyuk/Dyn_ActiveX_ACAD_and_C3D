namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointNamesExist 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumPointNamesExist _i;
		internal AeccPropertyEnumPointNamesExist(object AeccPropertyEnumPointNamesExist_object) 
		{
			this._i = AeccPropertyEnumPointNamesExist_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumPointNamesExist;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccPointNamesExistType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
