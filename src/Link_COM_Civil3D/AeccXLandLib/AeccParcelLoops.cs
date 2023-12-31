﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelLoops 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelLoops _i;
		internal AeccParcelLoops(object AeccParcelLoops_object) 
		{
			this._i = AeccParcelLoops_object as Autodesk.AECC.Interop.Land.IAeccParcelLoops;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;
	}
}
