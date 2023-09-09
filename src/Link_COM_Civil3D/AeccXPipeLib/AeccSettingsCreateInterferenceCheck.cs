namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateInterferenceCheck 
	{
		public AeccXPipeLib.IAeccSettingsCreateInterferenceCheck _i;
		internal AeccSettingsCreateInterferenceCheck(object AeccSettingsCreateInterferenceCheck_object) 
		{
			this._i = AeccSettingsCreateInterferenceCheck_object as AeccXPipeLib.IAeccSettingsCreateInterferenceCheck;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic InterferenceCriteriaSettings => this._i.InterferenceCriteriaSettings;
	}
}
