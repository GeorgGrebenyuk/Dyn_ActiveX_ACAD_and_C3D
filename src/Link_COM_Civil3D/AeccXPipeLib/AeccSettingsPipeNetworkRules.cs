namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPipeNetworkRules 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsPipeNetworkRules _i;
		internal AeccSettingsPipeNetworkRules(object AeccSettingsPipeNetworkRules_object) 
		{
			this._i = AeccSettingsPipeNetworkRules_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsPipeNetworkRules;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StructureDefaultRules => this._i.StructureDefaultRules;

		///<summary>
		///
		///</summary>
		public dynamic PipeDefaultRules => this._i.PipeDefaultRules;
	}
}
