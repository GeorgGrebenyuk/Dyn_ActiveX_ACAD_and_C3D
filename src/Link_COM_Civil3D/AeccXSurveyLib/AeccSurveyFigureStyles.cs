namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigureStyles 
	{
		public AeccXSurveyLib.IAeccSurveyFigureStyles _i;
		internal AeccSurveyFigureStyles(object AeccSurveyFigureStyles_object) 
		{
			this._i = AeccSurveyFigureStyles_object as AeccXSurveyLib.IAeccSurveyFigureStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrName) 
		{
			return this._i.Add(bstrName);
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
		public dynamic Item(object varId) 
		{
			return this._i.Item(varId);
		}
	}
}
