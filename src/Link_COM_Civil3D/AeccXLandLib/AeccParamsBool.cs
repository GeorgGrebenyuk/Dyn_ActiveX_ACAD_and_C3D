﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamsBool 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamsBool _i;
		internal AeccParamsBool(object AeccParamsBool_object) 
		{
			this._i = AeccParamsBool_object as Autodesk.AECC.Interop.Land.IAeccParamsBool;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Owner => this._i.Owner;

		///<summary>
		///
		///</summary>
		public void Put_Owner(dynamic ppVal) 
		{
			this._i.Owner = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrIndex,bool val) 
		{
			return this._i.Add(bstrIndex,val);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}

		///<summary>
		///
		///</summary>
		public bool Value(object Index) 
		{
			return this._i.Value(Index);
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
		public bool Global => this._i.Global;

		///<summary>
		///
		///</summary>
		public void Set_Global(bool pVal) 
		{
			this._i.Global = pVal;
		}
	}
}
