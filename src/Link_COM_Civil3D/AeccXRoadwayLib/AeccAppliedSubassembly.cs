namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAppliedSubassembly 
	{
		public AeccXRoadwayLib.IAeccAppliedSubassembly _i;
		internal AeccAppliedSubassembly(object AeccAppliedSubassembly_object) 
		{
			this._i = AeccAppliedSubassembly_object as AeccXRoadwayLib.IAeccAppliedSubassembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic CalculatedPoints => this._i.CalculatedPoints;

		///<summary>
		///
		///</summary>
		public dynamic CalculatedLinks => this._i.CalculatedLinks;

		///<summary>
		///
		///</summary>
		public dynamic CalculatedShapes => this._i.CalculatedShapes;

		///<summary>
		///
		///</summary>
		public object OriginStationOffsetElevationToBaseline => this._i.OriginStationOffsetElevationToBaseline;

		///<summary>
		///
		///</summary>
		public dynamic BaselineHookedTo => this._i.BaselineHookedTo;

		///<summary>
		///
		///</summary>
		public dynamic SubassemblyDbEntity => this._i.SubassemblyDbEntity;
	}
}
