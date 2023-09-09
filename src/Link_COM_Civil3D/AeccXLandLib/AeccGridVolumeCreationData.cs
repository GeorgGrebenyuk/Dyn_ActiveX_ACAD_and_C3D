namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridVolumeCreationData 
	{
		public Autodesk.AECC.Interop.Land.IAeccGridVolumeCreationData _i;
		internal AeccGridVolumeCreationData(object AeccGridVolumeCreationData_object) 
		{
			this._i = AeccGridVolumeCreationData_object as Autodesk.AECC.Interop.Land.IAeccGridVolumeCreationData;
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
