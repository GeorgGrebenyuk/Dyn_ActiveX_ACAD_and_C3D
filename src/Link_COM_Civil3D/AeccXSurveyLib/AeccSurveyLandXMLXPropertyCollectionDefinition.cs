﻿namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyCollectionDefinition 
	{
		public AeccXSurveyLib.IAeccSurveyLandXMLXPropertyCollectionDefinition _i;
		internal AeccSurveyLandXMLXPropertyCollectionDefinition(object AeccSurveyLandXMLXPropertyCollectionDefinition_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyCollectionDefinition_object as AeccXSurveyLib.IAeccSurveyLandXMLXPropertyCollectionDefinition;
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
