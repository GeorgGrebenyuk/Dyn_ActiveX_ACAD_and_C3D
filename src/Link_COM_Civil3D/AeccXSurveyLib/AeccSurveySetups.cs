namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySetups 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveySetups _i;
		internal AeccSurveySetups(object AeccSurveySetups_object) 
		{
			this._i = AeccSurveySetups_object as Autodesk.AECC.Interop.Survey.IAeccSurveySetups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Create(dynamic nStationPointNumber,dynamic nBacksightPointNumber) 
		{
			return this._i.Create(nStationPointNumber,nBacksightPointNumber);
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

		///<summary>
		///
		///</summary>
		public object FindSetupsThatObserve(dynamic nPointNumber) 
		{
			return this._i.FindSetupsThatObserve(nPointNumber);
		}
	}
}
