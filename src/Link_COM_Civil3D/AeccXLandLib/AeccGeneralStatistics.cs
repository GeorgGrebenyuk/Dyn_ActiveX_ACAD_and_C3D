namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGeneralStatistics 
	{
		public AeccXLandLib.IAeccGeneralStatistics _i;
		internal AeccGeneralStatistics(object AeccGeneralStatistics_object) 
		{
			this._i = AeccGeneralStatistics_object as AeccXLandLib.IAeccGeneralStatistics;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic RevisionNumber => this._i.RevisionNumber;

		///<summary>
		///
		///</summary>
		public dynamic NumberOfPoints => this._i.NumberOfPoints;

		///<summary>
		///
		///</summary>
		public double MinX => this._i.MinX;

		///<summary>
		///
		///</summary>
		public double MinY => this._i.MinY;

		///<summary>
		///
		///</summary>
		public double MaxX => this._i.MaxX;

		///<summary>
		///
		///</summary>
		public double MaxY => this._i.MaxY;

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
		public double MeanElevation => this._i.MeanElevation;
	}
}
