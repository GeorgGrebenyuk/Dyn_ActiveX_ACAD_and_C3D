namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewBandStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViewBandStyleSet _i;
		internal AeccSectionViewBandStyleSet(object AeccSectionViewBandStyleSet_object) 
		{
			this._i = AeccSectionViewBandStyleSet_object as Autodesk.AECC.Interop.Land.IAeccSectionViewBandStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
