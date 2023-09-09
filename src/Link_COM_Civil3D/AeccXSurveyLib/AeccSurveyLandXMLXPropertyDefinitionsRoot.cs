namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyDefinitionsRoot 
	{
		public AeccXSurveyLib.IAeccSurveyLandXMLXPropertyDefinitionsRoot _i;
		internal AeccSurveyLandXMLXPropertyDefinitionsRoot(object AeccSurveyLandXMLXPropertyDefinitionsRoot_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyDefinitionsRoot_object as AeccXSurveyLib.IAeccSurveyLandXMLXPropertyDefinitionsRoot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GetItems => this._i.GetItems;

		///<summary>
		///
		///</summary>
		public dynamic GetElements => this._i.GetElements;

		///<summary>
		///
		///</summary>
		public dynamic GetCollections => this._i.GetCollections;

		///<summary>
		///
		///</summary>
		public void CheckAll(bool bCheck) 
		{
			this._i.CheckAll(bCheck);
		}
	}
}
