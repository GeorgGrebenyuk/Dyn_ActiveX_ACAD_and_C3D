namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyDatabase 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyDatabase _i;
		internal AeccSurveyDatabase(object AeccSurveyDatabase_object) 
		{
			this._i = AeccSurveyDatabase_object as Autodesk.AECC.Interop.Survey.IAeccSurveyDatabase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FigureStyles => this._i.FigureStyles;

		///<summary>
		///
		///</summary>
		public dynamic NetworkStyles => this._i.NetworkStyles;

		///<summary>
		///
		///</summary>
		public dynamic Projects => this._i.Projects;

		///<summary>
		///
		///</summary>
		public dynamic CurrentProject => this._i.CurrentProject;

		///<summary>
		///
		///</summary>
		public dynamic GetUserSettings => this._i.GetUserSettings;

		///<summary>
		///
		///</summary>
		public void UpdateUserSettings(dynamic pUserSettings) 
		{
			this._i.UpdateUserSettings(pUserSettings);
		}

		///<summary>
		///
		///</summary>
		public dynamic EquipmentDatabases => this._i.EquipmentDatabases;

		///<summary>
		///
		///</summary>
		public dynamic FigurePrefixDatabases => this._i.FigurePrefixDatabases;
	}
}
