namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyXProperty 
	{
		public AeccXSurveyLib.IAeccSurveyXProperty _i;
		internal AeccSurveyXProperty(object AeccSurveyXProperty_object) 
		{
			this._i = AeccSurveyXProperty_object as AeccXSurveyLib.IAeccSurveyXProperty;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public object Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(object pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
