namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinSurfaceStatistics 
	{
		public Autodesk.AECC.Interop.Land.IAeccTinSurfaceStatistics _i;
		internal AeccTinSurfaceStatistics(object AeccTinSurfaceStatistics_object) 
		{
			this._i = AeccTinSurfaceStatistics_object as Autodesk.AECC.Interop.Land.IAeccTinSurfaceStatistics;
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
