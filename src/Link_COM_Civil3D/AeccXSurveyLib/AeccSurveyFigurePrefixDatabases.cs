namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigurePrefixDatabases 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyFigurePrefixDatabases _i;
		internal AeccSurveyFigurePrefixDatabases(object AeccSurveyFigurePrefixDatabases_object) 
		{
			this._i = AeccSurveyFigurePrefixDatabases_object as Autodesk.AECC.Interop.Survey.IAeccSurveyFigurePrefixDatabases;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
	}
}
