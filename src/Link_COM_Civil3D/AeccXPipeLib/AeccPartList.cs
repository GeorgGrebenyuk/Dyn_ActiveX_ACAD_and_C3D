namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartList 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartList _i;
		internal AeccPartList(object AeccPartList_object) 
		{
			this._i = AeccPartList_object as Autodesk.AECC.Interop.Pipe.IAeccPartList;
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
