﻿namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDimStyles 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDimStyles _i;
		internal AcadDimStyles(object AcadDimStyles_object) 
		{
			this._i = AcadDimStyles_object as Autodesk.AutoCAD.Interop.Common.AcadDimStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}
	}
}
