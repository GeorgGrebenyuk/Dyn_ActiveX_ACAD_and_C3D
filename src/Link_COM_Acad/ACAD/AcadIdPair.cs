﻿namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadIdPair 
	{
		public AXDBLib.IAcadIdPair _i;
		internal AcadIdPair(object AcadIdPair_object) 
		{
			this._i = AcadIdPair_object as AXDBLib.IAcadIdPair;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool IsCloned => this._i.IsCloned;

		///<summary>
		///
		///</summary>
		public bool IsOwnerXlated => this._i.IsOwnerXlated;

		///<summary>
		///
		///</summary>
		public bool IsPrimary => this._i.IsPrimary;

		///<summary>
		///
		///</summary>
		public dynamic key => this._i.key;

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public dynamic Application => this._i.Application;
	}
}