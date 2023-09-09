namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegment 
	{
		public AeccXLandLib.IAeccParcelSegment _i;
		internal AeccParcelSegment(object AeccParcelSegment_object) 
		{
			this._i = AeccParcelSegment_object as AeccXLandLib.IAeccParcelSegment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic SegmentLabels => this._i.SegmentLabels;
	}
}
