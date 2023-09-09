namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleSet 
	{
		public AeccXLandLib.IAeccLabelStyleSet _i;
		internal AeccLabelStyleSet(object AeccLabelStyleSet_object) 
		{
			this._i = AeccLabelStyleSet_object as AeccXLandLib.IAeccLabelStyleSet;
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
