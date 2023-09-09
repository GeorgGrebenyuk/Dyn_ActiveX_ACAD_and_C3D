namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridSurfaceStatistics 
	{
		public AeccXLandLib.IAeccGridSurfaceStatistics _i;
		internal AeccGridSurfaceStatistics(object AeccGridSurfaceStatistics_object) 
		{
			this._i = AeccGridSurfaceStatistics_object as AeccXLandLib.IAeccGridSurfaceStatistics;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Area2d => this._i.Area2d;

		///<summary>
		///
		///</summary>
		public double Area3d => this._i.Area3d;

		///<summary>
		///
		///</summary>
		public double MinGrade => this._i.MinGrade;

		///<summary>
		///
		///</summary>
		public double MaxGrade => this._i.MaxGrade;

		///<summary>
		///
		///</summary>
		public double MeanGrade => this._i.MeanGrade;
	}
}
