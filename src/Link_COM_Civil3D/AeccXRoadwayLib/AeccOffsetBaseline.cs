namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccOffsetBaseline 
	{
		public AeccXRoadwayLib.IAeccOffsetBaseline _i;
		internal AeccOffsetBaseline(object AeccOffsetBaseline_object) 
		{
			this._i = AeccOffsetBaseline_object as AeccXRoadwayLib.IAeccOffsetBaseline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public double StartStationOnMainBaseline => this._i.StartStationOnMainBaseline;

		///<summary>
		///
		///</summary>
		public double EndStationOnMainBaseline => this._i.EndStationOnMainBaseline;

		///<summary>
		///
		///</summary>
		public double OffsetBaselineStationToMainBaselineStation(double dSelfStation) 
		{
			return this._i.OffsetBaselineStationToMainBaselineStation(dSelfStation);
		}

		///<summary>
		///
		///</summary>
		public double MainBaselineStationToOffsetBaselineStation(double dMainStation) 
		{
			return this._i.MainBaselineStationToOffsetBaselineStation(dMainStation);
		}

		///<summary>
		///
		///</summary>
		public object GetOffsetElevationFromMainBaselineStation(double dMainStation) 
		{
			return this._i.GetOffsetElevationFromMainBaselineStation(dMainStation);
		}

		///<summary>
		///
		///</summary>
		public dynamic RelatedOffsetBaselineFeatureLines => this._i.RelatedOffsetBaselineFeatureLines;
	}
}
