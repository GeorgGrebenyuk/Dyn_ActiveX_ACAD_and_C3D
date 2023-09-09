namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionProjection 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionProjection _i;
		internal AeccSectionProjection(object AeccSectionProjection_object) 
		{
			this._i = AeccSectionProjection_object as Autodesk.AECC.Interop.Land.IAeccSectionProjection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
