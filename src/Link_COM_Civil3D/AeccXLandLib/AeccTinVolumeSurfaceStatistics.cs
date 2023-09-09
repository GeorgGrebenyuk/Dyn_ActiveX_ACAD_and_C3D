namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinVolumeSurfaceStatistics 
	{
		public AeccXLandLib.IAeccTinVolumeSurfaceStatistics _i;
		internal AeccTinVolumeSurfaceStatistics(object AeccTinVolumeSurfaceStatistics_object) 
		{
			this._i = AeccTinVolumeSurfaceStatistics_object as AeccXLandLib.IAeccTinVolumeSurfaceStatistics;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TopSurface => this._i.TopSurface;

		///<summary>
		///
		///</summary>
		public dynamic BottomSurface => this._i.BottomSurface;

		///<summary>
		///
		///</summary>
		public double CutVolume => this._i.CutVolume;

		///<summary>
		///
		///</summary>
		public double FillVolume => this._i.FillVolume;

		///<summary>
		///
		///</summary>
		public double NetVolume => this._i.NetVolume;

		///<summary>
		///
		///</summary>
		public void Volumes(out double pCut,out double pFill,out double pNet) 
		{
			this._i.Volumes(out pCut,out pFill,out pNet);
		}

		///<summary>
		///
		///</summary>
		public void BoundedVolumes(object varPoints,out double pCut,out double pFill,out double pNet) 
		{
			this._i.BoundedVolumes(varPoints,out pCut,out pFill,out pNet);
		}
	}
}
