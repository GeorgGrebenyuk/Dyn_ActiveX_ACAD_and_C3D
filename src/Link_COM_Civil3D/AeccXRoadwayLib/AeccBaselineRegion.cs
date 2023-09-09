namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaselineRegion 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccBaselineRegion _i;
		internal AeccBaselineRegion(object AeccBaselineRegion_object) 
		{
			this._i = AeccBaselineRegion_object as Autodesk.AECC.Interop.Roadway.IAeccBaselineRegion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public bool IsProcessed => this._i.IsProcessed;

		///<summary>
		///
		///</summary>
		public dynamic AppliedAssemblies => this._i.AppliedAssemblies;

		///<summary>
		///
		///</summary>
		public dynamic OffsetBaselines => this._i.OffsetBaselines;

		///<summary>
		///
		///</summary>
		public double StartStation => this._i.StartStation;

		///<summary>
		///
		///</summary>
		public double EndStation => this._i.EndStation;

		///<summary>
		///
		///</summary>
		public dynamic AssemblyDbEntity => this._i.AssemblyDbEntity;

		///<summary>
		///
		///</summary>
		public void GetSortedStations() 
		{
			this._i.GetSortedStations();
		}

		///<summary>
		///
		///</summary>
		public void GetAdditionalStations() 
		{
			this._i.GetAdditionalStations();
		}

		///<summary>
		///
		///</summary>
		public void ClearAdditionalStations() 
		{
			this._i.ClearAdditionalStations();
		}

		///<summary>
		///
		///</summary>
		public void AddStation(double rawStation,string Description) 
		{
			this._i.AddStation(rawStation,Description);
		}

		///<summary>
		///
		///</summary>
		public void DeleteStation(double rawStation,double tolerance) 
		{
			this._i.DeleteStation(rawStation,tolerance);
		}
	}
}
