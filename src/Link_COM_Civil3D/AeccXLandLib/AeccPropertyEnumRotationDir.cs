namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRotationDir 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumRotationDir _i;
		internal AeccPropertyEnumRotationDir(object AeccPropertyEnumRotationDir_object) 
		{
			this._i = AeccPropertyEnumRotationDir_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumRotationDir;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccRotationDirType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
