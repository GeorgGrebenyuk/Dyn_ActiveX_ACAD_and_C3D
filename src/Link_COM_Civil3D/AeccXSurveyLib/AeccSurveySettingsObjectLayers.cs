namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySettingsObjectLayers 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveySettingsObjectLayers _i;
		internal AeccSurveySettingsObjectLayers(object AeccSurveySettingsObjectLayers_object) 
		{
			this._i = AeccSurveySettingsObjectLayers_object as Autodesk.AECC.Interop.Survey.IAeccSurveySettingsObjectLayers;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurveyFigureLayer => this._i.SurveyFigureLayer;

		///<summary>
		///
		///</summary>
		public dynamic SurveyNetworkLayer => this._i.SurveyNetworkLayer;
	}
}
