namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeSettingsObjectLayers 
	{
		public AeccXPipeLib.IAeccPipeSettingsObjectLayers _i;
		internal AeccPipeSettingsObjectLayers(object AeccPipeSettingsObjectLayers_object) 
		{
			this._i = AeccPipeSettingsObjectLayers_object as AeccXPipeLib.IAeccPipeSettingsObjectLayers;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PipeLayer => this._i.PipeLayer;

		///<summary>
		///
		///</summary>
		public dynamic PipeNetworkSectionLayer => this._i.PipeNetworkSectionLayer;

		///<summary>
		///
		///</summary>
		public dynamic StructureLayer => this._i.StructureLayer;

		///<summary>
		///
		///</summary>
		public dynamic ProfilePipeAndStructureLayer => this._i.ProfilePipeAndStructureLayer;

		///<summary>
		///
		///</summary>
		public dynamic InterferenceLayer => this._i.InterferenceLayer;

		///<summary>
		///
		///</summary>
		public dynamic InterferenceCheckLayer => this._i.InterferenceCheckLayer;

		///<summary>
		///
		///</summary>
		public dynamic NetworkLayer => this._i.NetworkLayer;
	}
}
