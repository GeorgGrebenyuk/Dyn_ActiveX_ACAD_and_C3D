namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySettingsDrawing 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveySettingsDrawing _i;
		internal AeccSurveySettingsDrawing(object AeccSurveySettingsDrawing_object) 
		{
			this._i = AeccSurveySettingsDrawing_object as Autodesk.AECC.Interop.Survey.IAeccSurveySettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
