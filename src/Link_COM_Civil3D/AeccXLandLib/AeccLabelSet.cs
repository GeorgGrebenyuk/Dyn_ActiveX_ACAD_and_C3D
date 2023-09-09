namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelSet 
	{
		public AeccXLandLib.IAeccLabelSet _i;
		internal AeccLabelSet(object AeccLabelSet_object) 
		{
			this._i = AeccLabelSet_object as AeccXLandLib.IAeccLabelSet;
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
