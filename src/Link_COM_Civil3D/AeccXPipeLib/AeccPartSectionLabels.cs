﻿namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartSectionLabels 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartSectionLabels _i;
		internal AeccPartSectionLabels(object AeccPartSectionLabels_object) 
		{
			this._i = AeccPartSectionLabels_object as Autodesk.AECC.Interop.Pipe.IAeccPartSectionLabels;
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
