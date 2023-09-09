namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfacePointFiles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfacePointFiles _i;
		internal AeccSurfacePointFiles(object AeccSurfacePointFiles_object) 
		{
			this._i = AeccSurfacePointFiles_object as Autodesk.AECC.Interop.Land.IAeccSurfacePointFiles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string FileName,string FileFormatName,bool DoElevationAdjustment,bool DoCoordinateTransformation,bool DoCoordinateDataExpansion) 
		{
			return this._i.Add(FileName,FileFormatName,DoElevationAdjustment,DoCoordinateTransformation,DoCoordinateDataExpansion);
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
