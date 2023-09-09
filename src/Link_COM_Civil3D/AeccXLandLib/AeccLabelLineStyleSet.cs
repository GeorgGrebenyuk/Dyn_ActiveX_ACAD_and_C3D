namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelLineStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelLineStyleSet _i;
		internal AeccLabelLineStyleSet(object AeccLabelLineStyleSet_object) 
		{
			this._i = AeccLabelLineStyleSet_object as Autodesk.AECC.Interop.Land.IAeccLabelLineStyleSet;
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
