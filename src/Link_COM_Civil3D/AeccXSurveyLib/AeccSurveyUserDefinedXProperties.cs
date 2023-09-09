namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyUserDefinedXProperties 
	{
		public AeccXSurveyLib.IAeccSurveyUserDefinedXProperties _i;
		internal AeccSurveyUserDefinedXProperties(object AeccSurveyUserDefinedXProperties_object) 
		{
			this._i = AeccSurveyUserDefinedXProperties_object as AeccXSurveyLib.IAeccSurveyUserDefinedXProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
