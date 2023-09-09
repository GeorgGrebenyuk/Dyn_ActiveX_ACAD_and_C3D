namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccQueryStatement 
	{
		public Autodesk.AECC.Interop.Land.IAeccQueryStatement _i;
		internal AeccQueryStatement(object AeccQueryStatement_object) 
		{
			this._i = AeccQueryStatement_object as Autodesk.AECC.Interop.Land.IAeccQueryStatement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add => this._i.Add;

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
		public void Clear() 
		{
			this._i.Clear();
		}

		///<summary>
		///
		///</summary>
		public string QueryText => this._i.QueryText;
	}
}
