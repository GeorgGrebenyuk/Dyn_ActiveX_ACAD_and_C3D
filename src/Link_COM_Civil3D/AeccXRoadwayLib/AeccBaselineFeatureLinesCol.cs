namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaselineFeatureLinesCol 
	{
		public AeccXRoadwayLib.IAeccBaselineFeatureLinesCol _i;
		internal AeccBaselineFeatureLinesCol(object AeccBaselineFeatureLinesCol_object) 
		{
			this._i = AeccBaselineFeatureLinesCol_object as AeccXRoadwayLib.IAeccBaselineFeatureLinesCol;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

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
