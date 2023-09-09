namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeSettingsRoot 
	{
		public AeccXPipeLib.IAeccPipeSettingsRoot _i;
		internal AeccPipeSettingsRoot(object AeccPipeSettingsRoot_object) 
		{
			this._i = AeccPipeSettingsRoot_object as AeccXPipeLib.IAeccPipeSettingsRoot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PartLists => this._i.PartLists;

		///<summary>
		///
		///</summary>
		public dynamic PipeNetworkCatDef => this._i.PipeNetworkCatDef;

		///<summary>
		///
		///</summary>
		public dynamic PipeNetworkSettings => this._i.PipeNetworkSettings;

		///<summary>
		///
		///</summary>
		public dynamic PipeNetworkCommandsSettings => this._i.PipeNetworkCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic PipeSettings => this._i.PipeSettings;

		///<summary>
		///
		///</summary>
		public dynamic StructureSettings => this._i.StructureSettings;
	}
}
