namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedPoint 
	{
		public AeccXRoadwayLib.IAeccCalculatedPoint _i;
		internal AeccCalculatedPoint(object AeccCalculatedPoint_object) 
		{
			this._i = AeccCalculatedPoint_object as AeccXRoadwayLib.IAeccCalculatedPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object NormalToSubassembly => this._i.NormalToSubassembly;

		///<summary>
		///
		///</summary>
		public object StationOffsetElevationToSubassembly => this._i.StationOffsetElevationToSubassembly;

		///<summary>
		///
		///</summary>
		public object GetNormalToBaseline => this._i.GetNormalToBaseline;

		///<summary>
		///
		///</summary>
		public object GetStationOffsetElevationToBaseline => this._i.GetStationOffsetElevationToBaseline;
	}
}
