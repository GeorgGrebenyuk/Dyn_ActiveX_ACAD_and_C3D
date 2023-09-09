namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyProjects 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyProjects _i;
		internal AeccSurveyProjects(object AeccSurveyProjects_object) 
		{
			this._i = AeccSurveyProjects_object as Autodesk.AECC.Interop.Survey.IAeccSurveyProjects;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic FindItem(object varIndex) 
		{
			return this._i.FindItem(varIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic Create(string bstrName) 
		{
			return this._i.Create(bstrName);
		}

		///<summary>
		///
		///</summary>
		public string GetWorkingFolder => this._i.GetWorkingFolder;

		///<summary>
		///
		///</summary>
		public void SetWorkingFolder(string bstrPath) 
		{
			this._i.SetWorkingFolder(bstrPath);
		}
	}
}
