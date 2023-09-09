namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStyles 
	{
		public AeccXPipeLib.IAeccPipeStyles _i;
		internal AeccPipeStyles(object AeccPipeStyles_object) 
		{
			this._i = AeccPipeStyles_object as AeccXPipeLib.IAeccPipeStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

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
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
