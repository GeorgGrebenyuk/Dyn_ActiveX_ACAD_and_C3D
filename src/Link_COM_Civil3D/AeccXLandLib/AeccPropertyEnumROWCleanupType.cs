namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumROWCleanupType 
	{
		public AeccXLandLib.IAeccPropertyEnumROWCleanupType _i;
		internal AeccPropertyEnumROWCleanupType(object AeccPropertyEnumROWCleanupType_object) 
		{
			this._i = AeccPropertyEnumROWCleanupType_object as AeccXLandLib.IAeccPropertyEnumROWCleanupType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccROWCleanupType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
