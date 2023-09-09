namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccNoteLabels 
	{
		public AeccXLandLib.IAeccNoteLabels _i;
		internal AeccNoteLabels(object AeccNoteLabels_object) 
		{
			this._i = AeccNoteLabels_object as AeccXLandLib.IAeccNoteLabels;
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
