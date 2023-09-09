namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleSet _i;
		internal AeccLabelStyleSet(object AeccLabelStyleSet_object) 
		{
			this._i = AeccLabelStyleSet_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleSet;
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
