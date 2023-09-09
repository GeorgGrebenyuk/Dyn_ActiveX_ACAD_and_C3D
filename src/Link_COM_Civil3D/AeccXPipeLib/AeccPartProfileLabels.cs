namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartProfileLabels 
	{
		public AeccXPipeLib.IAeccPartProfileLabels _i;
		internal AeccPartProfileLabels(object AeccPartProfileLabels_object) 
		{
			this._i = AeccPartProfileLabels_object as AeccXPipeLib.IAeccPartProfileLabels;
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
