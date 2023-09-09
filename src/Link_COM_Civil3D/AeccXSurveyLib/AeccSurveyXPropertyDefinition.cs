namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyXPropertyDefinition 
	{
		public AeccXSurveyLib.IAeccSurveyXPropertyDefinition _i;
		internal AeccSurveyXPropertyDefinition(object AeccSurveyXPropertyDefinition_object) 
		{
			this._i = AeccSurveyXPropertyDefinition_object as AeccXSurveyLib.IAeccSurveyXPropertyDefinition;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string XmlName => this._i.XmlName;

		///<summary>
		///
		///</summary>
		public string DisplayName => this._i.DisplayName;

		///<summary>
		///
		///</summary>
		public void Set_DisplayName(string pVal) 
		{
			this._i.DisplayName = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pVal) 
		{
			this._i.Description = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public bool Required => this._i.Required;

		///<summary>
		///
		///</summary>
		public void Set_Required(bool pbRequired) 
		{
			this._i.Required = pbRequired;
		}

		///<summary>
		///
		///</summary>
		public bool Displayed => this._i.Displayed;

		///<summary>
		///
		///</summary>
		public void Set_Displayed(bool pbDisplayed) 
		{
			this._i.Displayed = pbDisplayed;
		}

		///<summary>
		///
		///</summary>
		public object StringArray => this._i.StringArray;

		///<summary>
		///
		///</summary>
		public void Set_StringArray(object pStringArray) 
		{
			this._i.StringArray = pStringArray;
		}
	}
}
