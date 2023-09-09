﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedPoints 
	{
		public AeccXRoadwayLib.IAeccCalculatedPoints _i;
		internal AeccCalculatedPoints(object AeccCalculatedPoints_object) 
		{
			this._i = AeccCalculatedPoints_object as AeccXRoadwayLib.IAeccCalculatedPoints;
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
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
