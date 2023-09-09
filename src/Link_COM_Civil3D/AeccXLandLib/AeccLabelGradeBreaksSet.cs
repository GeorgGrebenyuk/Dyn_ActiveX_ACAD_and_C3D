namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGradeBreaksSet 
	{
		public AeccXLandLib.IAeccLabelGradeBreaksSet _i;
		internal AeccLabelGradeBreaksSet(object AeccLabelGradeBreaksSet_object) 
		{
			this._i = AeccLabelGradeBreaksSet_object as AeccXLandLib.IAeccLabelGradeBreaksSet;
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
