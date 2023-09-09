namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayLinkStyle 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayLinkStyle _i;
		internal AeccRoadwayLinkStyle(object AeccRoadwayLinkStyle_object) 
		{
			this._i = AeccRoadwayLinkStyle_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayLinkStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LinkDisplayStyle2d => this._i.LinkDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic LinkDisplayStyle3d => this._i.LinkDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic LinkDisplayStylePlan => this._i.LinkDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic LinkDisplayStyleModel => this._i.LinkDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic LinkDisplayStyleSection => this._i.LinkDisplayStyleSection;
	}
}
