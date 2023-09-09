namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceDEMFiles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceDEMFiles _i;
		internal AeccSurfaceDEMFiles(object AeccSurfaceDEMFiles_object) 
		{
			this._i = AeccSurfaceDEMFiles_object as Autodesk.AECC.Interop.Land.IAeccSurfaceDEMFiles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string FileName) 
		{
			return this._i.Add(FileName);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex) 
		{
			this._i.Remove(varIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
