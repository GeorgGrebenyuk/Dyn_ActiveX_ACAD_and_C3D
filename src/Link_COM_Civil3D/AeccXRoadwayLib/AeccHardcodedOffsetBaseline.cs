namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccHardcodedOffsetBaseline 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccHardcodedOffsetBaseline _i;
		internal AeccHardcodedOffsetBaseline(object AeccHardcodedOffsetBaseline_object) 
		{
			this._i = AeccHardcodedOffsetBaseline_object as Autodesk.AECC.Interop.Roadway.IAeccHardcodedOffsetBaseline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public object OffsetElevationFromMainBaseline => this._i.OffsetElevationFromMainBaseline;

		///<summary>
		///
		///</summary>
		public dynamic RelatedOffsetBaselineFeatureLines => this._i.RelatedOffsetBaselineFeatureLines;
	}
}
