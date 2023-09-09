namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigurePrefixDatabase 
	{
		public AeccXSurveyLib.IAeccSurveyFigurePrefixDatabase _i;
		internal AeccSurveyFigurePrefixDatabase(object AeccSurveyFigurePrefixDatabase_object) 
		{
			this._i = AeccSurveyFigurePrefixDatabase_object as AeccXSurveyLib.IAeccSurveyFigurePrefixDatabase;
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
		public dynamic GetMatchedFigurePrefix(string bstrName) 
		{
			return this._i.GetMatchedFigurePrefix(bstrName);
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
		public void Remove(object varId) 
		{
			this._i.Remove(varId);
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
		public bool ImportFrom(dynamic piFigurePrefixDatabase) 
		{
			return this._i.ImportFrom(piFigurePrefixDatabase);
		}
	}
}
