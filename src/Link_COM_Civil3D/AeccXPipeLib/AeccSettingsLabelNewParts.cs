namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsLabelNewParts 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsLabelNewParts _i;
		internal AeccSettingsLabelNewParts(object AeccSettingsLabelNewParts_object) 
		{
			this._i = AeccSettingsLabelNewParts_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsLabelNewParts;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PipeInPlan => this._i.PipeInPlan;

		///<summary>
		///
		///</summary>
		public dynamic PipeProfile => this._i.PipeProfile;

		///<summary>
		///
		///</summary>
		public dynamic StructureInPlan => this._i.StructureInPlan;

		///<summary>
		///
		///</summary>
		public dynamic StructureProfile => this._i.StructureProfile;
	}
}
