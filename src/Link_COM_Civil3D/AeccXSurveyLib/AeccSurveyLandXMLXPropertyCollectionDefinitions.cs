﻿namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyCollectionDefinitions 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyCollectionDefinitions _i;
		internal AeccSurveyLandXMLXPropertyCollectionDefinitions(object AeccSurveyLandXMLXPropertyCollectionDefinitions_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyCollectionDefinitions_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyCollectionDefinitions;
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
	}
}
