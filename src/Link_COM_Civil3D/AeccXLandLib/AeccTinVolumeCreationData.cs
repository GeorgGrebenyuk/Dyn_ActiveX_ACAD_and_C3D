namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinVolumeCreationData 
	{
		public AeccXLandLib.IAeccTinVolumeCreationData _i;
		internal AeccTinVolumeCreationData(object AeccTinVolumeCreationData_object) 
		{
			this._i = AeccTinVolumeCreationData_object as AeccXLandLib.IAeccTinVolumeCreationData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic BaseSurface => this._i.BaseSurface;

		///<summary>
		///
		///</summary>
		public void Put_BaseSurface(dynamic pVal) 
		{
			this._i.BaseSurface = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ComparisonSurface => this._i.ComparisonSurface;

		///<summary>
		///
		///</summary>
		public void Put_ComparisonSurface(dynamic pVal) 
		{
			this._i.ComparisonSurface = pVal;
		}
	}
}
