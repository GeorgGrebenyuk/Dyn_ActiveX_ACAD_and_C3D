﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedShapes 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCalculatedShapes _i;
		internal AeccCalculatedShapes(object AeccCalculatedShapes_object) 
		{
			this._i = AeccCalculatedShapes_object as Autodesk.AECC.Interop.Roadway.IAeccCalculatedShapes;
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
