namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsViewEditOptions 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsViewEditOptions _i;
		internal AeccSettingsViewEditOptions(object AeccSettingsViewEditOptions_object) 
		{
			this._i = AeccSettingsViewEditOptions_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsViewEditOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultViewScale => this._i.DefaultViewScale;

		///<summary>
		///
		///</summary>
		public dynamic TurnOffUnassociatedLayers => this._i.TurnOffUnassociatedLayers;

		///<summary>
		///
		///</summary>
		public dynamic RebuildOnEdit => this._i.RebuildOnEdit;

		///<summary>
		///
		///</summary>
		public dynamic FrontClip => this._i.FrontClip;

		///<summary>
		///
		///</summary>
		public dynamic BackClip => this._i.BackClip;

		///<summary>
		///
		///</summary>
		public dynamic StationTrackerInMultiViewports => this._i.StationTrackerInMultiViewports;
	}
}
