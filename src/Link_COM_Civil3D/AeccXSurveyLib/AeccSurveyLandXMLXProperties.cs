namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXProperties 
	{
		public AeccXSurveyLib.IAeccSurveyLandXMLXProperties _i;
		internal AeccSurveyLandXMLXProperties(object AeccSurveyLandXMLXProperties_object) 
		{
			this._i = AeccSurveyLandXMLXProperties_object as AeccXSurveyLib.IAeccSurveyLandXMLXProperties;
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
