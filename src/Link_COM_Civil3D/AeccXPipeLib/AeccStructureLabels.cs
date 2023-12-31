﻿namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureLabels 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureLabels _i;
		internal AeccStructureLabels(object AeccStructureLabels_object) 
		{
			this._i = AeccStructureLabels_object as Autodesk.AECC.Interop.Pipe.IAeccStructureLabels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}
	}
}
