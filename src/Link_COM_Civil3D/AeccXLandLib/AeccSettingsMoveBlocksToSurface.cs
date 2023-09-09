namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMoveBlocksToSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMoveBlocksToSurface _i;
		internal AeccSettingsMoveBlocksToSurface(object AeccSettingsMoveBlocksToSurface_object) 
		{
			this._i = AeccSettingsMoveBlocksToSurface_object as Autodesk.AECC.Interop.Land.IAeccSettingsMoveBlocksToSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
