namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayShapeStyles 
	{
		public AeccXRoadwayLib.IAeccRoadwayShapeStyles _i;
		internal AeccRoadwayShapeStyles(object AeccRoadwayShapeStyles_object) 
		{
			this._i = AeccRoadwayShapeStyles_object as AeccXRoadwayLib.IAeccRoadwayShapeStyles;
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

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
