﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelBaseStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelBaseStyleSet _i;
		internal AeccLabelBaseStyleSet(object AeccLabelBaseStyleSet_object) 
		{
			this._i = AeccLabelBaseStyleSet_object as Autodesk.AECC.Interop.Land.IAeccLabelBaseStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}
	}
}
