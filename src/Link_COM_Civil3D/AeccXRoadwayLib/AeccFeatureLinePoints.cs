﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLinePoints 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccFeatureLinePoints _i;
		internal AeccFeatureLinePoints(object AeccFeatureLinePoints_object) 
		{
			this._i = AeccFeatureLinePoints_object as Autodesk.AECC.Interop.Roadway.IAeccFeatureLinePoints;
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
