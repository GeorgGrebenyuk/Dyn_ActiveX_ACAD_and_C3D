﻿namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyLandXMLXPropertiesRoot 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertiesRoot _i;
		internal AeccSurveyLandXMLXPropertiesRoot(object AeccSurveyLandXMLXPropertiesRoot_object) 
		{
			this._i = AeccSurveyLandXMLXPropertiesRoot_object as Autodesk.AECC.Interop.Survey.IAeccSurveyLandXMLXPropertiesRoot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GetItems => this._i.GetItems;

		///<summary>
		///
		///</summary>
		public dynamic GetElements => this._i.GetElements;

		///<summary>
		///
		///</summary>
		public dynamic GetCollections => this._i.GetCollections;
	}
}
