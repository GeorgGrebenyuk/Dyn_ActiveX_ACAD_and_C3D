namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceAnalysisElevation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceAnalysisElevation _i;
		internal AeccSurfaceAnalysisElevation(object AeccSurfaceAnalysisElevation_object) 
		{
			this._i = AeccSurfaceAnalysisElevation_object as Autodesk.AECC.Interop.Land.IAeccSurfaceAnalysisElevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ElevationRegions => this._i.ElevationRegions;

		///<summary>
		///
		///</summary>
		public dynamic CalculateElevationRegions(int numGroupsRequested,bool bScaleSchemeToFit) 
		{
			return this._i.CalculateElevationRegions(numGroupsRequested,bScaleSchemeToFit);
		}
	}
}
