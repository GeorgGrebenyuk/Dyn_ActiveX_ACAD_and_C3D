namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyProject 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyProject _i;
		internal AeccSurveyProject(object AeccSurveyProject_object) 
		{
			this._i = AeccSurveyProject_object as Autodesk.AECC.Interop.Survey.IAeccSurveyProject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public string ProjectGUID => this._i.ProjectGUID;

		///<summary>
		///
		///</summary>
		public dynamic Networks => this._i.Networks;

		///<summary>
		///
		///</summary>
		public dynamic Figures => this._i.Figures;

		///<summary>
		///
		///</summary>
		public void RecalculateFigures(dynamic piDatabase) 
		{
			this._i.RecalculateFigures(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetProjectSettings => this._i.GetProjectSettings;

		///<summary>
		///
		///</summary>
		public void UpdateProjectSettings(dynamic piProjectSettings) 
		{
			this._i.UpdateProjectSettings(piProjectSettings);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetPointByNumber(dynamic nPointNumber) 
		{
			return this._i.GetPointByNumber(nPointNumber);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetNextWritablePointNumber => this._i.GetNextWritablePointNumber;

		///<summary>
		///
		///</summary>
		public bool IsPointReadable(dynamic nPointNumber) 
		{
			return this._i.IsPointReadable(nPointNumber);
		}

		///<summary>
		///
		///</summary>
		public object GetPointNumbers => this._i.GetPointNumbers;

		///<summary>
		///
		///</summary>
		public void DeletePointByNumber(dynamic nPointNumber) 
		{
			this._i.DeletePointByNumber(nPointNumber);
		}

		///<summary>
		///
		///</summary>
		public double SurveyNullValue => this._i.SurveyNullValue;

		///<summary>
		///
		///</summary>
		public void Open() 
		{
			this._i.Open();
		}

		///<summary>
		///
		///</summary>
		public void OpenEx(bool bForRead) 
		{
			this._i.OpenEx(bForRead);
		}

		///<summary>
		///
		///</summary>
		public void Close() 
		{
			this._i.Close();
		}

		///<summary>
		///
		///</summary>
		public dynamic GetLandXMLXPropertyDefinitionsRoot(Autodesk.AECC.Interop.Survey.AeccSurveyFeatureType FeatureType) 
		{
			return this._i.GetLandXMLXPropertyDefinitionsRoot(FeatureType);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetUserDefinedXPropertyDefinitions(Autodesk.AECC.Interop.Survey.AeccSurveyFeatureType FeatureType) 
		{
			return this._i.GetUserDefinedXPropertyDefinitions(FeatureType);
		}

		///<summary>
		///
		///</summary>
		public dynamic LandXMLXPropertiesRoot => this._i.LandXMLXPropertiesRoot;

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedXProperties => this._i.UserDefinedXProperties;

		///<summary>
		///
		///</summary>
		public void QueueXPropertyEdits(bool bEnable) 
		{
			this._i.QueueXPropertyEdits(bEnable);
		}

		///<summary>
		///
		///</summary>
		public void FlushXPropertyEdits() 
		{
			this._i.FlushXPropertyEdits();
		}
	}
}
