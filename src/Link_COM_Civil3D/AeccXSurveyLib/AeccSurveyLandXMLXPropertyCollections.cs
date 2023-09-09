namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyCollections 
	{
		public AeccXSurveyLib.IAeccSurveyLandXMLXPropertyCollections _i;
		internal AeccSurveyLandXMLXPropertyCollections(object AeccSurveyLandXMLXPropertyCollections_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyCollections_object as AeccXSurveyLib.IAeccSurveyLandXMLXPropertyCollections;
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
