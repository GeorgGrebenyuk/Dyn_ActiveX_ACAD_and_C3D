namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelLineStyleSet 
	{
		public AeccXLandLib.IAeccLabelLineStyleSet _i;
		internal AeccLabelLineStyleSet(object AeccLabelLineStyleSet_object) 
		{
			this._i = AeccLabelLineStyleSet_object as AeccXLandLib.IAeccLabelLineStyleSet;
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
