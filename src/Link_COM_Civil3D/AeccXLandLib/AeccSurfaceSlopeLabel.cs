namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceSlopeLabel 
	{
		public AeccXLandLib.IAeccSurfaceSlopeLabel _i;
		internal AeccSurfaceSlopeLabel(object AeccSurfaceSlopeLabel_object) 
		{
			this._i = AeccSurfaceSlopeLabel_object as AeccXLandLib.IAeccSurfaceSlopeLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;
	}
}
