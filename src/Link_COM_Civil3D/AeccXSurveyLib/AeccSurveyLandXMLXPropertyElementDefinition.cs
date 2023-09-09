namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyElementDefinition 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyElementDefinition _i;
		internal AeccSurveyLandXMLXPropertyElementDefinition(object AeccSurveyLandXMLXPropertyElementDefinition_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyElementDefinition_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyElementDefinition;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic XPropertyDefinitions => this._i.XPropertyDefinitions;

		///<summary>
		///
		///</summary>
		public void CheckAll(bool bCheck) 
		{
			this._i.CheckAll(bCheck);
		}
	}
}
