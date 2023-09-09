namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingVolumeTools 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGradingVolumeTools _i;
		internal AeccSettingsGradingVolumeTools(object AeccSettingsGradingVolumeTools_object) 
		{
			this._i = AeccSettingsGradingVolumeTools_object as Autodesk.AECC.Interop.Land.IAeccSettingsGradingVolumeTools;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic RaiseLowerElevIncrement => this._i.RaiseLowerElevIncrement;

		///<summary>
		///
		///</summary>
		public dynamic LimitToCurrentGroup => this._i.LimitToCurrentGroup;
	}
}
