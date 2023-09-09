namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLinesCol 
	{
		public AeccXRoadwayLib.IAeccFeatureLinesCol _i;
		internal AeccFeatureLinesCol(object AeccFeatureLinesCol_object) 
		{
			this._i = AeccFeatureLinesCol_object as AeccXRoadwayLib.IAeccFeatureLinesCol;
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
		public string CodeNames => this._i.CodeNames;

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndexOrCode) 
		{
			return this._i.Item(varIndexOrCode);
		}
	}
}
