namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyUserDefinedXPropertyDefinitions 
	{
		public AeccXSurveyLib.IAeccSurveyUserDefinedXPropertyDefinitions _i;
		internal AeccSurveyUserDefinedXPropertyDefinitions(object AeccSurveyUserDefinedXPropertyDefinitions_object) 
		{
			this._i = AeccSurveyUserDefinedXPropertyDefinitions_object as AeccXSurveyLib.IAeccSurveyUserDefinedXPropertyDefinitions;
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
		public dynamic Add(string XmlName,string DisplayName,string Description,AeccXSurveyLib.AeccSurveyXPropertyType Type,bool bRequired,bool bDisplayed,object EnumStringArray) 
		{
			return this._i.Add(XmlName,DisplayName,Description,Type,bRequired,bDisplayed,EnumStringArray);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
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
