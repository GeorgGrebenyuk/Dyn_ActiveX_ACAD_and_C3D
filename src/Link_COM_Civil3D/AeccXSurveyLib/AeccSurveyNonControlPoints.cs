namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNonControlPoints 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyNonControlPoints _i;
		internal AeccSurveyNonControlPoints(object AeccSurveyNonControlPoints_object) 
		{
			this._i = AeccSurveyNonControlPoints_object as Autodesk.AECC.Interop.Survey.IAeccSurveyNonControlPoints;
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
