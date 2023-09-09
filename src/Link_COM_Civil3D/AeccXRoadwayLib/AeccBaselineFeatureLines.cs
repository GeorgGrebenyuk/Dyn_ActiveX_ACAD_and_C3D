namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaselineFeatureLines 
	{
		public AeccXRoadwayLib.IAeccBaselineFeatureLines _i;
		internal AeccBaselineFeatureLines(object AeccBaselineFeatureLines_object) 
		{
			this._i = AeccBaselineFeatureLines_object as AeccXRoadwayLib.IAeccBaselineFeatureLines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLinesCol => this._i.FeatureLinesCol;

		///<summary>
		///
		///</summary>
		public bool IsMainBaseline => this._i.IsMainBaseline;

		///<summary>
		///
		///</summary>
		public dynamic OffsetAlignment => this._i.OffsetAlignment;

		///<summary>
		///
		///</summary>
		public string HardcodedOffsetBaselineName => this._i.HardcodedOffsetBaselineName;

		///<summary>
		///
		///</summary>
		public string CodeNames => this._i.CodeNames;
	}
}
