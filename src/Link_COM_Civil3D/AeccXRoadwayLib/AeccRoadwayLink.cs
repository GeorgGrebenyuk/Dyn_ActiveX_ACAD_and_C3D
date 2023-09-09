namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayLink 
	{
		public AeccXRoadwayLib.IAeccRoadwayLink _i;
		internal AeccRoadwayLink(object AeccRoadwayLink_object) 
		{
			this._i = AeccRoadwayLink_object as AeccXRoadwayLib.IAeccRoadwayLink;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Index => this._i.Index;

		///<summary>
		///
		///</summary>
		public dynamic RoadwayCodes => this._i.RoadwayCodes;

		///<summary>
		///
		///</summary>
		public dynamic Points => this._i.Points;

		///<summary>
		///
		///</summary>
		public bool IsHidden => this._i.IsHidden;

		///<summary>
		///
		///</summary>
		public void Set_IsHidden(bool pVal) 
		{
			this._i.IsHidden = pVal;
		}
	}
}
