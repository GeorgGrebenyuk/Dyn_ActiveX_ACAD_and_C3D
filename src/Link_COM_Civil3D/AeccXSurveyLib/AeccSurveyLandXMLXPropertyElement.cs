namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyElement 
	{
		public AeccXSurveyLib.IAeccSurveyLandXMLXPropertyElement _i;
		internal AeccSurveyLandXMLXPropertyElement(object AeccSurveyLandXMLXPropertyElement_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyElement_object as AeccXSurveyLib.IAeccSurveyLandXMLXPropertyElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic XProperties => this._i.XProperties;
	}
}
