namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurvey 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSettingsSurvey _i;
		internal AeccSettingsSurvey(object AeccSettingsSurvey_object) 
		{
			this._i = AeccSettingsSurvey_object as Autodesk.AECC.Interop.Survey.IAeccSettingsSurvey;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
