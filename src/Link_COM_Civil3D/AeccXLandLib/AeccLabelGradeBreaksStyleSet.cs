namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGradeBreaksStyleSet 
	{
		public AeccXLandLib.IAeccLabelGradeBreaksStyleSet _i;
		internal AeccLabelGradeBreaksStyleSet(object AeccLabelGradeBreaksStyleSet_object) 
		{
			this._i = AeccLabelGradeBreaksStyleSet_object as AeccXLandLib.IAeccLabelGradeBreaksStyleSet;
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
