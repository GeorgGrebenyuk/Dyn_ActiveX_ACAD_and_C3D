﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceLabels 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceLabels _i;
		internal AeccSurfaceLabels(object AeccSurfaceLabels_object) 
		{
			this._i = AeccSurfaceLabels_object as Autodesk.AECC.Interop.Land.IAeccSurfaceLabels;
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
