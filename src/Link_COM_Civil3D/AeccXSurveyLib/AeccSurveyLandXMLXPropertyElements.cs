﻿namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertyElements 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyElements _i;
		internal AeccSurveyLandXMLXPropertyElements(object AeccSurveyLandXMLXPropertyElements_object) 
		{
			this._i = AeccSurveyLandXMLXPropertyElements_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertyElements;
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
