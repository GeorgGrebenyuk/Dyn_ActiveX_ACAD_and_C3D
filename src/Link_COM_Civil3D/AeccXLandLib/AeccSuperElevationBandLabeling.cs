namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSuperElevationBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccSuperElevationBandLabeling _i;
		internal AeccSuperElevationBandLabeling(object AeccSuperElevationBandLabeling_object) 
		{
			this._i = AeccSuperElevationBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccSuperElevationBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
