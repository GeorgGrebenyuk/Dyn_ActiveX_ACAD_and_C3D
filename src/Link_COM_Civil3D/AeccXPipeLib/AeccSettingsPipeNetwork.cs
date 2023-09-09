namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPipeNetwork 
	{
		public AeccXPipeLib.IAeccSettingsPipeNetwork _i;
		internal AeccSettingsPipeNetwork(object AeccSettingsPipeNetwork_object) 
		{
			this._i = AeccSettingsPipeNetwork_object as AeccXPipeLib.IAeccSettingsPipeNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NetworkNameTemplate => this._i.NetworkNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic StructureNameTemplate => this._i.StructureNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic PipeNameTemplate => this._i.PipeNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic RulesSettings => this._i.RulesSettings;

		///<summary>
		///
		///</summary>
		public dynamic ProfileLabelPlacementSettings => this._i.ProfileLabelPlacementSettings;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
