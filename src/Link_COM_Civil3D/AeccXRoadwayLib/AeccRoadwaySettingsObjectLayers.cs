namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwaySettingsObjectLayers 
	{
		public AeccXRoadwayLib.IAeccRoadwaySettingsObjectLayers _i;
		internal AeccRoadwaySettingsObjectLayers(object AeccRoadwaySettingsObjectLayers_object) 
		{
			this._i = AeccRoadwaySettingsObjectLayers_object as AeccXRoadwayLib.IAeccRoadwaySettingsObjectLayers;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AssemblyLayer => this._i.AssemblyLayer;

		///<summary>
		///
		///</summary>
		public dynamic CorridorLayer => this._i.CorridorLayer;

		///<summary>
		///
		///</summary>
		public dynamic SubassemblyLayer => this._i.SubassemblyLayer;

		///<summary>
		///
		///</summary>
		public dynamic CorridorSectionLayer => this._i.CorridorSectionLayer;

		///<summary>
		///
		///</summary>
		public dynamic RoadwayStateLayer => this._i.RoadwayStateLayer;
	}
}
