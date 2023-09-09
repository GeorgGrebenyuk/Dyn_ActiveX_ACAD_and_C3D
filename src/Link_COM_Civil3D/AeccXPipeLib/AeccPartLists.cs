namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartLists 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartLists _i;
		internal AeccPartLists(object AeccPartLists_object) 
		{
			this._i = AeccPartLists_object as Autodesk.AECC.Interop.Pipe.IAeccPartLists;
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
