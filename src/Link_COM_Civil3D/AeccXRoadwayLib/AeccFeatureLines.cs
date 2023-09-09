namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLines 
	{
		public AeccXRoadwayLib.IAeccFeatureLines _i;
		internal AeccFeatureLines(object AeccFeatureLines_object) 
		{
			this._i = AeccFeatureLines_object as AeccXRoadwayLib.IAeccFeatureLines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCodeInfo => this._i.FeatureLineCodeInfo;

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
