namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeDatabase 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeDatabase _i;
		internal AeccPipeDatabase(object AeccPipeDatabase_object) 
		{
			this._i = AeccPipeDatabase_object as Autodesk.AECC.Interop.Pipe.IAeccPipeDatabase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PipeStyles => this._i.PipeStyles;

		///<summary>
		///
		///</summary>
		public dynamic StructureStyles => this._i.StructureStyles;

		///<summary>
		///
		///</summary>
		public dynamic PipeNetworks => this._i.PipeNetworks;

		///<summary>
		///
		///</summary>
		public dynamic NetworkState => this._i.NetworkState;

		///<summary>
		///
		///</summary>
		public dynamic InterferenceChecks => this._i.InterferenceChecks;

		///<summary>
		///
		///</summary>
		public dynamic InterferenceStyles => this._i.InterferenceStyles;

		///<summary>
		///
		///</summary>
		public dynamic PipeNetworkLabelStyles => this._i.PipeNetworkLabelStyles;

		///<summary>
		///
		///</summary>
		public object STMProjectMetadata => this._i.STMProjectMetadata;

		///<summary>
		///
		///</summary>
		public void Set_STMProjectMetadata(object pData) 
		{
			this._i.STMProjectMetadata = pData;
		}
	}
}
