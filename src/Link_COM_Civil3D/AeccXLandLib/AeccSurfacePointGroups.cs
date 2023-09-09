namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfacePointGroups 
	{
		public AeccXLandLib.IAeccSurfacePointGroups _i;
		internal AeccSurfacePointGroups(object AeccSurfacePointGroups_object) 
		{
			this._i = AeccSurfacePointGroups_object as AeccXLandLib.IAeccSurfacePointGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex) 
		{
			this._i.Remove(varIndex);
		}

		///<summary>
		///
		///</summary>
		public void Add(dynamic PointGroup) 
		{
			this._i.Add(PointGroup);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
