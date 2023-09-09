namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyBaseObject 
	{
		public AeccXSurveyLib.IAeccSurveyBaseObject _i;
		internal AeccSurveyBaseObject(object AeccSurveyBaseObject_object) 
		{
			this._i = AeccSurveyBaseObject_object as AeccXSurveyLib.IAeccSurveyBaseObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
