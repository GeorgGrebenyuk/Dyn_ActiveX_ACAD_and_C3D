namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLine 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccFeatureLine _i;
		internal AeccFeatureLine(object AeccFeatureLine_object) 
		{
			this._i = AeccFeatureLine_object as Autodesk.AECC.Interop.Roadway.IAeccFeatureLine;
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
		public dynamic FeatureLinePoints => this._i.FeatureLinePoints;
	}
}
