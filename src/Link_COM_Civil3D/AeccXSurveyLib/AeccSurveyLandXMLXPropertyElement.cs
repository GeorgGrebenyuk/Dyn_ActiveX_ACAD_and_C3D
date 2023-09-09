namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyElement 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyElement _i;
		internal AeccSurveyLandXMLXPropertyElement(object AeccSurveyLandXMLXPropertyElement_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyElement_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic XProperties => this._i.XProperties;
	}
}
