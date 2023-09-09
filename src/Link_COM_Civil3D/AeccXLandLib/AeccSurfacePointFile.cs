namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfacePointFile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfacePointFile _i;
		internal AeccSurfacePointFile(object AeccSurfacePointFile_object) 
		{
			this._i = AeccSurfacePointFile_object as Autodesk.AECC.Interop.Land.IAeccSurfacePointFile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;
	}
}
