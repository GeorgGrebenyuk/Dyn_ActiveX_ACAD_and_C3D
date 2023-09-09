namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaseline 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccBaseline _i;
		internal AeccBaseline(object AeccBaseline_object) 
		{
			this._i = AeccBaseline_object as Autodesk.AECC.Interop.Roadway.IAeccBaseline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool IsProcessed => this._i.IsProcessed;

		///<summary>
		///
		///</summary>
		public dynamic BaselineRegions => this._i.BaselineRegions;

		///<summary>
		///
		///</summary>
		public dynamic AppliedAssembly(object Station) 
		{
			return this._i.AppliedAssembly(Station);
		}

		///<summary>
		///
		///</summary>
		public dynamic OffsetBaselineFeatureLinesCol => this._i.OffsetBaselineFeatureLinesCol;

		///<summary>
		///
		///</summary>
		public dynamic MainBaselineFeatureLines => this._i.MainBaselineFeatureLines;

		///<summary>
		///
		///</summary>
		public void AddStation(double rawStation) 
		{
			this._i.AddStation(rawStation);
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
