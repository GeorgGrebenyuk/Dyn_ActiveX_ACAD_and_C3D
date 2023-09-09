namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNetworks 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyNetworks _i;
		internal AeccSurveyNetworks(object AeccSurveyNetworks_object) 
		{
			this._i = AeccSurveyNetworks_object as Autodesk.AECC.Interop.Survey.IAeccSurveyNetworks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Create(string pbstrName) 
		{
			return this._i.Create(pbstrName);
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
