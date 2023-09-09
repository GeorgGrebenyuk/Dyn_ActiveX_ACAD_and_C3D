namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeLabels 
	{
		public AeccXPipeLib.IAeccPipeLabels _i;
		internal AeccPipeLabels(object AeccPipeLabels_object) 
		{
			this._i = AeccPipeLabels_object as AeccXPipeLib.IAeccPipeLabels;
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
