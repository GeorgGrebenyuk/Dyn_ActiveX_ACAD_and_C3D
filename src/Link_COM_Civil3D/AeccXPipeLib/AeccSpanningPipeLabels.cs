namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSpanningPipeLabels 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSpanningPipeLabels _i;
		internal AeccSpanningPipeLabels(object AeccSpanningPipeLabels_object) 
		{
			this._i = AeccSpanningPipeLabels_object as Autodesk.AECC.Interop.Pipe.IAeccSpanningPipeLabels;
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
