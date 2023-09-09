namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayShape 
	{
		public AeccXRoadwayLib.IAeccRoadwayShape _i;
		internal AeccRoadwayShape(object AeccRoadwayShape_object) 
		{
			this._i = AeccRoadwayShape_object as AeccXRoadwayLib.IAeccRoadwayShape;
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
		public dynamic Links => this._i.Links;

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
