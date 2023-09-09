namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwaySettingsRoot 
	{
		public AeccXRoadwayLib.IAeccRoadwaySettingsRoot _i;
		internal AeccRoadwaySettingsRoot(object AeccRoadwaySettingsRoot_object) 
		{
			this._i = AeccRoadwaySettingsRoot_object as AeccXRoadwayLib.IAeccRoadwaySettingsRoot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CorridorSettings => this._i.CorridorSettings;

		///<summary>
		///
		///</summary>
		public dynamic CorridorCommandsSettings => this._i.CorridorCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic AssemblySettings => this._i.AssemblySettings;

		///<summary>
		///
		///</summary>
		public dynamic AssemblyCommandsSettings => this._i.AssemblyCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic SubassemblySettings => this._i.SubassemblySettings;

		///<summary>
		///
		///</summary>
		public dynamic SubassemblyCommandsSettings => this._i.SubassemblyCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic QuantityTakeoffSettings => this._i.QuantityTakeoffSettings;

		///<summary>
		///
		///</summary>
		public dynamic QuantityTakeoffCommandsSettings => this._i.QuantityTakeoffCommandsSettings;
	}
}
