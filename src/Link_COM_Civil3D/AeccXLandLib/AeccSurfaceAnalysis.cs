namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceAnalysis 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceAnalysis _i;
		internal AeccSurfaceAnalysis(object AeccSurfaceAnalysis_object) 
		{
			this._i = AeccSurfaceAnalysis_object as Autodesk.AECC.Interop.Land.IAeccSurfaceAnalysis;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic WatershedAnalysis => this._i.WatershedAnalysis;

		///<summary>
		///
		///</summary>
		public dynamic ElevationAnalysis => this._i.ElevationAnalysis;
	}
}
