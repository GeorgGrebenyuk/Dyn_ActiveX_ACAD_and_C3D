namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartSizeFilters 
	{
		public AeccXPipeLib.IAeccPartSizeFilters _i;
		internal AeccPartSizeFilters(object AeccPartSizeFilters_object) 
		{
			this._i = AeccPartSizeFilters_object as AeccXPipeLib.IAeccPartSizeFilters;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object nIndex) 
		{
			return this._i.Item(nIndex);
		}
	}
}
