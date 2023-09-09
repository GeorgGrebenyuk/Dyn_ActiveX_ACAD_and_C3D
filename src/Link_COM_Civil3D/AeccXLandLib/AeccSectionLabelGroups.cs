namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelGroups 
	{
		public AeccXLandLib.IAeccSectionLabelGroups _i;
		internal AeccSectionLabelGroups(object AeccSectionLabelGroups_object) 
		{
			this._i = AeccSectionLabelGroups_object as AeccXLandLib.IAeccSectionLabelGroups;
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
