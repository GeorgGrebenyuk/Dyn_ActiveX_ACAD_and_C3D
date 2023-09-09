namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyControlPoints 
	{
		public AeccXSurveyLib.IAeccSurveyControlPoints _i;
		internal AeccSurveyControlPoints(object AeccSurveyControlPoints_object) 
		{
			this._i = AeccSurveyControlPoints_object as AeccXSurveyLib.IAeccSurveyControlPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Create(dynamic nPointNumber,string bstrName,string bstrDescription,double dEasting,double dNorthing,double dElevation) 
		{
			return this._i.Create(nPointNumber,bstrName,bstrDescription,dEasting,dNorthing,dElevation);
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
