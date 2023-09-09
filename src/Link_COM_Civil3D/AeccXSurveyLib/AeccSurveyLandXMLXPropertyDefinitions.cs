namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyDefinitions 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyDefinitions _i;
		internal AeccSurveyLandXMLXPropertyDefinitions(object AeccSurveyLandXMLXPropertyDefinitions_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyDefinitions_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyDefinitions;
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

		///<summary>
		///
		///</summary>
		public void CheckAll(bool bCheck) 
		{
			this._i.CheckAll(bCheck);
		}
	}
}
