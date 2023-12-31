﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLineComponents 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccFeatureLineComponents _i;
		internal AeccFeatureLineComponents(object AeccFeatureLineComponents_object) 
		{
			this._i = AeccFeatureLineComponents_object as Autodesk.AECC.Interop.Roadway.IAeccFeatureLineComponents;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
