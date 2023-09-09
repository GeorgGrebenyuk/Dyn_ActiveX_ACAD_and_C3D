namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNetworkStyles 
	{
		public AeccXSurveyLib.IAeccSurveyNetworkStyles _i;
		internal AeccSurveyNetworkStyles(object AeccSurveyNetworkStyles_object) 
		{
			this._i = AeccSurveyNetworkStyles_object as AeccXSurveyLib.IAeccSurveyNetworkStyles;
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
