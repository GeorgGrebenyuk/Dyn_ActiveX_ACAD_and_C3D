namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLineCodeInfo 
	{
		public AeccXRoadwayLib.IAeccFeatureLineCodeInfo _i;
		internal AeccFeatureLineCodeInfo(object AeccFeatureLineCodeInfo_object) 
		{
			this._i = AeccFeatureLineCodeInfo_object as AeccXRoadwayLib.IAeccFeatureLineCodeInfo;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public string CodeName => this._i.CodeName;

		///<summary>
		///
		///</summary>
		public bool IsDraw => this._i.IsDraw;

		///<summary>
		///
		///</summary>
		public bool IsConnect => this._i.IsConnect;
	}
}
