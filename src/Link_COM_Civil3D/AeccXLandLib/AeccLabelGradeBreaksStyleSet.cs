namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGradeBreaksStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelGradeBreaksStyleSet _i;
		internal AeccLabelGradeBreaksStyleSet(object AeccLabelGradeBreaksStyleSet_object) 
		{
			this._i = AeccLabelGradeBreaksStyleSet_object as Autodesk.AECC.Interop.Land.IAeccLabelGradeBreaksStyleSet;
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
