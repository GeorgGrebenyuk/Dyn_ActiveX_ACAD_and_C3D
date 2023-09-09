namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigureNodes 
	{
		public AeccXSurveyLib.IAeccSurveyFigureNodes _i;
		internal AeccSurveyFigureNodes(object AeccSurveyFigureNodes_object) 
		{
			this._i = AeccSurveyFigureNodes_object as AeccXSurveyLib.IAeccSurveyFigureNodes;
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
	}
}
