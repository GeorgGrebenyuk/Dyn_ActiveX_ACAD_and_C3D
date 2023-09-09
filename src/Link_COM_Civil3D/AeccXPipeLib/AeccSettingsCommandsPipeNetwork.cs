namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsPipeNetwork 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsCommandsPipeNetwork _i;
		internal AeccSettingsCommandsPipeNetwork(object AeccSettingsCommandsPipeNetwork_object) 
		{
			this._i = AeccSettingsCommandsPipeNetwork_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsCommandsPipeNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkPartPlanLabel => this._i.AddNetworkPartPlanLabel;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkPartProfLabel => this._i.AddNetworkPartProfLabel;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkPartSectLabel => this._i.AddNetworkPartSectLabel;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkPartsToProf => this._i.AddNetworkPartsToProf;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkPipeTable => this._i.AddNetworkPipeTable;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkPlanLabels => this._i.AddNetworkPlanLabels;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkProfLabels => this._i.AddNetworkProfLabels;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkSectLabels => this._i.AddNetworkSectLabels;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkStructTable => this._i.AddNetworkStructTable;

		///<summary>
		///
		///</summary>
		public dynamic AddSpanningPipePlanLabel => this._i.AddSpanningPipePlanLabel;

		///<summary>
		///
		///</summary>
		public dynamic AddSpanningPipeProfLabel => this._i.AddSpanningPipeProfLabel;

		///<summary>
		///
		///</summary>
		public dynamic CreateAlignFromNetwork => this._i.CreateAlignFromNetwork;

		///<summary>
		///
		///</summary>
		public dynamic CreateInterferenceCheck => this._i.CreateInterferenceCheck;

		///<summary>
		///
		///</summary>
		public dynamic CreateNetwork => this._i.CreateNetwork;

		///<summary>
		///
		///</summary>
		public dynamic CreateNetworkFromObject => this._i.CreateNetworkFromObject;

		///<summary>
		///
		///</summary>
		public dynamic CreateNetworkPartsList => this._i.CreateNetworkPartsList;

		///<summary>
		///
		///</summary>
		public dynamic CreateNetworkReference => this._i.CreateNetworkReference;

		///<summary>
		///
		///</summary>
		public dynamic ExportStormSewerData => this._i.ExportStormSewerData;

		///<summary>
		///
		///</summary>
		public dynamic ImportStormSewerData => this._i.ImportStormSewerData;

		///<summary>
		///
		///</summary>
		public dynamic RenamePipeNetworkParts => this._i.RenamePipeNetworkParts;

		///<summary>
		///
		///</summary>
		public dynamic ResetAnchorPipe => this._i.ResetAnchorPipe;

		///<summary>
		///
		///</summary>
		public dynamic ShowSpanningPipes => this._i.ShowSpanningPipes;

		///<summary>
		///
		///</summary>
		public dynamic CreateNetworkPartsListFull => this._i.CreateNetworkPartsListFull;

		///<summary>
		///
		///</summary>
		public dynamic EditInStormSewers => this._i.EditInStormSewers;
	}
}
