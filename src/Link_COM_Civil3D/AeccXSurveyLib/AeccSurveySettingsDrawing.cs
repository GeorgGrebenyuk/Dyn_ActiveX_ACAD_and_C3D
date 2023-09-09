namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySettingsDrawing 
	{
		public AeccXSurveyLib.IAeccSurveySettingsDrawing _i;
		internal AeccSurveySettingsDrawing(object AeccSurveySettingsDrawing_object) 
		{
			this._i = AeccSurveySettingsDrawing_object as AeccXSurveyLib.IAeccSurveySettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
