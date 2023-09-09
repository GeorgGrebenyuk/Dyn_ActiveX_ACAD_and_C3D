namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingVolumeTools 
	{
		public AeccXLandLib.IAeccSettingsGradingVolumeTools _i;
		internal AeccSettingsGradingVolumeTools(object AeccSettingsGradingVolumeTools_object) 
		{
			this._i = AeccSettingsGradingVolumeTools_object as AeccXLandLib.IAeccSettingsGradingVolumeTools;
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
