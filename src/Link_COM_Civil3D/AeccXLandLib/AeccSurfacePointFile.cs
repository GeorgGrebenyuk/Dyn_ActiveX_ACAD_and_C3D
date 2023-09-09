namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfacePointFile 
	{
		public AeccXLandLib.IAeccSurfacePointFile _i;
		internal AeccSurfacePointFile(object AeccSurfacePointFile_object) 
		{
			this._i = AeccSurfacePointFile_object as AeccXLandLib.IAeccSurfacePointFile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;
	}
}
