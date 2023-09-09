namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelSegmentStyleSet 
	{
		public AeccXLandLib.IAeccLabelSegmentStyleSet _i;
		internal AeccLabelSegmentStyleSet(object AeccLabelSegmentStyleSet_object) 
		{
			this._i = AeccLabelSegmentStyleSet_object as AeccXLandLib.IAeccLabelSegmentStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic LabelStyle) 
		{
			return this._i.Add(LabelStyle);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}
	}
}
