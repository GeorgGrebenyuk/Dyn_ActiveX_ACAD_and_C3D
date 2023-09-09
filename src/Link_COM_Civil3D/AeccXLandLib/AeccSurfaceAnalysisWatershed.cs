namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceAnalysisWatershed 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceAnalysisWatershed _i;
		internal AeccSurfaceAnalysisWatershed(object AeccSurfaceAnalysisWatershed_object) 
		{
			this._i = AeccSurfaceAnalysisWatershed_object as Autodesk.AECC.Interop.Land.IAeccSurfaceAnalysisWatershed;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double MergeDepression => this._i.MergeDepression;

		///<summary>
		///
		///</summary>
		public void Set_MergeDepression(double pVal) 
		{
			this._i.MergeDepression = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool MergeAdjacentBoundaries => this._i.MergeAdjacentBoundaries;

		///<summary>
		///
		///</summary>
		public void Set_MergeAdjacentBoundaries(bool pVal) 
		{
			this._i.MergeAdjacentBoundaries = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic WatershedRegions => this._i.WatershedRegions;

		///<summary>
		///
		///</summary>
		public bool RebuildWatershedsState => this._i.RebuildWatershedsState;

		///<summary>
		///
		///</summary>
		public void Set_RebuildWatershedsState(bool pVal) 
		{
			this._i.RebuildWatershedsState = pVal;
		}

		///<summary>
		///
		///</summary>
		public void CalculateWatersheds() 
		{
			this._i.CalculateWatersheds();
		}
	}
}
