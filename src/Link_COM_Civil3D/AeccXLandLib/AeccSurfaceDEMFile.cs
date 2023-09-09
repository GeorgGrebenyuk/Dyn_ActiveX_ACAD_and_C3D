namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceDEMFile 
	{
		public AeccXLandLib.IAeccSurfaceDEMFile _i;
		internal AeccSurfaceDEMFile(object AeccSurfaceDEMFile_object) 
		{
			this._i = AeccSurfaceDEMFile_object as AeccXLandLib.IAeccSurfaceDEMFile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public dynamic EstimatedPointCount => this._i.EstimatedPointCount;

		///<summary>
		///
		///</summary>
		public string CoordinateSystemType => this._i.CoordinateSystemType;

		///<summary>
		///
		///</summary>
		public string Zone => this._i.Zone;

		///<summary>
		///
		///</summary>
		public string HorizontalDatum => this._i.HorizontalDatum;

		///<summary>
		///
		///</summary>
		public string VerticalDatum => this._i.VerticalDatum;

		///<summary>
		///
		///</summary>
		public dynamic DEMLevel => this._i.DEMLevel;

		///<summary>
		///
		///</summary>
		public double MinElevation => this._i.MinElevation;

		///<summary>
		///
		///</summary>
		public double MaxElevation => this._i.MaxElevation;

		///<summary>
		///
		///</summary>
		public double XSpacing => this._i.XSpacing;

		///<summary>
		///
		///</summary>
		public double YSpacing => this._i.YSpacing;

		///<summary>
		///
		///</summary>
		public string XYUnit => this._i.XYUnit;

		///<summary>
		///
		///</summary>
		public string ElevationUnit => this._i.ElevationUnit;
	}
}
