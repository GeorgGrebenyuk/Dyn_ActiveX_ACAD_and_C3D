namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyPoints 
	{
		public AeccXSurveyLib.IAeccSurveyPoints _i;
		internal AeccSurveyPoints(object AeccSurveyPoints_object) 
		{
			this._i = AeccSurveyPoints_object as AeccXSurveyLib.IAeccSurveyPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic varIndex) 
		{
			return this._i.Item(varIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic FindItem(object varId) 
		{
			return this._i.FindItem(varId);
		}
	}
}
