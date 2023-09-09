namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceContourLabelGroups 
	{
		public AeccXLandLib.IAeccSurfaceContourLabelGroups _i;
		internal AeccSurfaceContourLabelGroups(object AeccSurfaceContourLabelGroups_object) 
		{
			this._i = AeccSurfaceContourLabelGroups_object as AeccXLandLib.IAeccSurfaceContourLabelGroups;
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
