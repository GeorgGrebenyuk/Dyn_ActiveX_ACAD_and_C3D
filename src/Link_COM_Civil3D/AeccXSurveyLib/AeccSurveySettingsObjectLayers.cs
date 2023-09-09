namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySettingsObjectLayers 
	{
		public AeccXSurveyLib.IAeccSurveySettingsObjectLayers _i;
		internal AeccSurveySettingsObjectLayers(object AeccSurveySettingsObjectLayers_object) 
		{
			this._i = AeccSurveySettingsObjectLayers_object as AeccXSurveyLib.IAeccSurveySettingsObjectLayers;
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
