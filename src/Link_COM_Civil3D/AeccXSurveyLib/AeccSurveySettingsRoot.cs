namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySettingsRoot 
	{
		public AeccXSurveyLib.IAeccSurveySettingsRoot _i;
		internal AeccSurveySettingsRoot(object AeccSurveySettingsRoot_object) 
		{
			this._i = AeccSurveySettingsRoot_object as AeccXSurveyLib.IAeccSurveySettingsRoot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurveySettings => this._i.SurveySettings;
	}
}
