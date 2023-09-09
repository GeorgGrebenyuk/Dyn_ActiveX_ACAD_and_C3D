namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateInterferenceCheck 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateInterferenceCheck _i;
		internal AeccSettingsCreateInterferenceCheck(object AeccSettingsCreateInterferenceCheck_object) 
		{
			this._i = AeccSettingsCreateInterferenceCheck_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateInterferenceCheck;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic InterferenceCriteriaSettings => this._i.InterferenceCriteriaSettings;
	}
}
