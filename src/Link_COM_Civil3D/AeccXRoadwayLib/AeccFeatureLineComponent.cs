namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLineComponent 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccFeatureLineComponent _i;
		internal AeccFeatureLineComponent(object AeccFeatureLineComponent_object) 
		{
			this._i = AeccFeatureLineComponent_object as Autodesk.AECC.Interop.Roadway.IAeccFeatureLineComponent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLine => this._i.FeatureLine;

		///<summary>
		///
		///</summary>
		public bool IsReversed => this._i.IsReversed;

		///<summary>
		///
		///</summary>
		public double StartStation => this._i.StartStation;

		///<summary>
		///
		///</summary>
		public double EndStation => this._i.EndStation;

		///<summary>
		///
		///</summary>
		public bool UseStartStation => this._i.UseStartStation;

		///<summary>
		///
		///</summary>
		public bool UseEndStation => this._i.UseEndStation;
	}
}
