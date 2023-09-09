namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyTraverses 
	{
		public AeccXSurveyLib.IAeccSurveyTraverses _i;
		internal AeccSurveyTraverses(object AeccSurveyTraverses_object) 
		{
			this._i = AeccSurveyTraverses_object as AeccXSurveyLib.IAeccSurveyTraverses;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Create(string pbstrName,dynamic nInitialStationPointNumber,dynamic nInitialBacksightPointNumber,dynamic nFinalForesightPointNumber,object varStationPointNumbers) 
		{
			return this._i.Create(pbstrName,nInitialStationPointNumber,nInitialBacksightPointNumber,nFinalForesightPointNumber,varStationPointNumbers);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex) 
		{
			this._i.Remove(varIndex);
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
