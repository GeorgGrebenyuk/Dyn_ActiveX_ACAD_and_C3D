namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineVertices 
	{
		public AeccXLandLib.IAeccSampleLineVertices _i;
		internal AeccSampleLineVertices(object AeccSampleLineVertices_object) 
		{
			this._i = AeccSampleLineVertices_object as AeccXLandLib.IAeccSampleLineVertices;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic CountLeft => this._i.CountLeft;

		///<summary>
		///
		///</summary>
		public dynamic CountRight => this._i.CountRight;

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
		public dynamic Add(object Location,AeccXLandLib.AeccAlignmentSideType AlignmentSide,AeccXLandLib.AeccDirectionFromType DirectionFrom) 
		{
			return this._i.Add(Location,AlignmentSide,DirectionFrom);
		}

		///<summary>
		///
		///</summary>
		public dynamic Insert(dynamic Index,object Location,AeccXLandLib.AeccAlignmentSideType AlignmentSide,AeccXLandLib.AeccDirectionFromType DirectionFrom) 
		{
			return this._i.Insert(Index,Location,AlignmentSide,DirectionFrom);
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
