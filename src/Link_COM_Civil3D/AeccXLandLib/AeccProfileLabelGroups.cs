namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelGroups 
	{
		public AeccXLandLib.IAeccProfileLabelGroups _i;
		internal AeccProfileLabelGroups(object AeccProfileLabelGroups_object) 
		{
			this._i = AeccProfileLabelGroups_object as AeccXLandLib.IAeccProfileLabelGroups;
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
