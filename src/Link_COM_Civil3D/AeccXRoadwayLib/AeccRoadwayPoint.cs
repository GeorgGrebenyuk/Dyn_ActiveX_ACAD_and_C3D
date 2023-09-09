namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayPoint 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayPoint _i;
		internal AeccRoadwayPoint(object AeccRoadwayPoint_object) 
		{
			this._i = AeccRoadwayPoint_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public void Set_Station(double pVal) 
		{
			this._i.Station = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Offset => this._i.Offset;

		///<summary>
		///
		///</summary>
		public void Set_Offset(double pVal) 
		{
			this._i.Offset = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pVal) 
		{
			this._i.Elevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic RoadwayCodes => this._i.RoadwayCodes;

		///<summary>
		///
		///</summary>
		public dynamic Index => this._i.Index;

		///<summary>
		///
		///</summary>
		public bool IsLoopPoint => this._i.IsLoopPoint;

		///<summary>
		///
		///</summary>
		public void Set_IsLoopPoint(bool pVal) 
		{
			this._i.IsLoopPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsHidden => this._i.IsHidden;

		///<summary>
		///
		///</summary>
		public void Set_IsHidden(bool pVal) 
		{
			this._i.IsHidden = pVal;
		}
	}
}
