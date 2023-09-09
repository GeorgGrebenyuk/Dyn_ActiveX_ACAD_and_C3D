namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyBaseObject 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyBaseObject _i;
		internal AeccSurveyBaseObject(object AeccSurveyBaseObject_object) 
		{
			this._i = AeccSurveyBaseObject_object as Autodesk.AECC.Interop.Survey.IAeccSurveyBaseObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
