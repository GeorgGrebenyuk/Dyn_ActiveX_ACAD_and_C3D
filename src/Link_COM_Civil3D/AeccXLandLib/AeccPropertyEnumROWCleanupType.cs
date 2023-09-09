namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumROWCleanupType 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumROWCleanupType _i;
		internal AeccPropertyEnumROWCleanupType(object AeccPropertyEnumROWCleanupType_object) 
		{
			this._i = AeccPropertyEnumROWCleanupType_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumROWCleanupType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccROWCleanupType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
