namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLineCodeInfos 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccFeatureLineCodeInfos _i;
		internal AeccFeatureLineCodeInfos(object AeccFeatureLineCodeInfos_object) 
		{
			this._i = AeccFeatureLineCodeInfos_object as Autodesk.AECC.Interop.Roadway.IAeccFeatureLineCodeInfos;
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
