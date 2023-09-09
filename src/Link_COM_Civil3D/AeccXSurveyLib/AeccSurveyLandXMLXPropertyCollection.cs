namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyCollection 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyCollection _i;
		internal AeccSurveyLandXMLXPropertyCollection(object AeccSurveyLandXMLXPropertyCollection_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyCollection_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyCollection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic New => this._i.New;

		///<summary>
		///
		///</summary>
		public void Delete(dynamic Index) 
		{
			this._i.Delete(Index);
		}
	}
}
