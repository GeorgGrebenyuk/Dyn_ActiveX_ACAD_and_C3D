namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaseBaseline 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccBaseBaseline _i;
		internal AeccBaseBaseline(object AeccBaseBaseline_object) 
		{
			this._i = AeccBaseBaseline_object as Autodesk.AECC.Interop.Roadway.IAeccBaseBaseline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;

		///<summary>
		///
		///</summary>
		public dynamic Profile => this._i.Profile;

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
		public void GetSortedStations() 
		{
			this._i.GetSortedStations();
		}

		///<summary>
		///
		///</summary>
		public object StationOffsetElevationToXYZ(object soe) 
		{
			return this._i.StationOffsetElevationToXYZ(soe);
		}

		///<summary>
		///
		///</summary>
		public object GetDirectionAtStation(double dStation) 
		{
			return this._i.GetDirectionAtStation(dStation);
		}
	}
}
