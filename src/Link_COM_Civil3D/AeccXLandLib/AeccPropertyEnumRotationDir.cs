namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRotationDir 
	{
		public AeccXLandLib.IAeccPropertyEnumRotationDir _i;
		internal AeccPropertyEnumRotationDir(object AeccPropertyEnumRotationDir_object) 
		{
			this._i = AeccPropertyEnumRotationDir_object as AeccXLandLib.IAeccPropertyEnumRotationDir;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccRotationDirType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
