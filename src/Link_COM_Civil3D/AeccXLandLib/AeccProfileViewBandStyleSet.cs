namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewBandStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileViewBandStyleSet _i;
		internal AeccProfileViewBandStyleSet(object AeccProfileViewBandStyleSet_object) 
		{
			this._i = AeccProfileViewBandStyleSet_object as Autodesk.AECC.Interop.Land.IAeccProfileViewBandStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
