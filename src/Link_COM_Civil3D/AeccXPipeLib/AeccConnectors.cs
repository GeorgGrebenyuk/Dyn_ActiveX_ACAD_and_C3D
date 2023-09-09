namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccConnectors 
	{
		public AeccXPipeLib.IAeccConnectors _i;
		internal AeccConnectors(object AeccConnectors_object) 
		{
			this._i = AeccConnectors_object as AeccXPipeLib.IAeccConnectors;
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
	}
}
