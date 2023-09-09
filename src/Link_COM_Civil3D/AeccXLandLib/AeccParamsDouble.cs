namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamsDouble 
	{
		public AeccXLandLib.IAeccParamsDouble _i;
		internal AeccParamsDouble(object AeccParamsDouble_object) 
		{
			this._i = AeccParamsDouble_object as AeccXLandLib.IAeccParamsDouble;
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
		public dynamic Add(string bstrIndex,double val) 
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
		public double Value(object Index) 
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
