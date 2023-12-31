﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedShape 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCalculatedShape _i;
		internal AeccCalculatedShape(object AeccCalculatedShape_object) 
		{
			this._i = AeccCalculatedShape_object as Autodesk.AECC.Interop.Roadway.IAeccCalculatedShape;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CalculatedLinks => this._i.CalculatedLinks;

		///<summary>
		///
		///</summary>
		public double GetArea => this._i.GetArea;
	}
}
