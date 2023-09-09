namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyElementDefinitions 
	{
		public AeccXSurveyLib.IAeccSurveyLandXMLXPropertyElementDefinitions _i;
		internal AeccSurveyLandXMLXPropertyElementDefinitions(object AeccSurveyLandXMLXPropertyElementDefinitions_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyElementDefinitions_object as AeccXSurveyLib.IAeccSurveyLandXMLXPropertyElementDefinitions;
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
