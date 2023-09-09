namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamsPoint 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamsPoint _i;
		internal AeccParamsPoint(object AeccParamsPoint_object) 
		{
			this._i = AeccParamsPoint_object as Autodesk.AECC.Interop.Land.IAeccParamsPoint;
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
		public dynamic Add(string bstrIndex) 
		{
			return this._i.Add(bstrIndex);
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
