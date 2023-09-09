namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceSlopeLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceSlopeLabel _i;
		internal AeccSurfaceSlopeLabel(object AeccSurfaceSlopeLabel_object) 
		{
			this._i = AeccSurfaceSlopeLabel_object as Autodesk.AECC.Interop.Land.IAeccSurfaceSlopeLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;
	}
}
