namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurvey 
	{
		public AeccXSurveyLib.IAeccSettingsSurvey _i;
		internal AeccSettingsSurvey(object AeccSettingsSurvey_object) 
		{
			this._i = AeccSettingsSurvey_object as AeccXSurveyLib.IAeccSettingsSurvey;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
