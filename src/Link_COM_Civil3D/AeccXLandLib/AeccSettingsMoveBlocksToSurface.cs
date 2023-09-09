namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMoveBlocksToSurface 
	{
		public AeccXLandLib.IAeccSettingsMoveBlocksToSurface _i;
		internal AeccSettingsMoveBlocksToSurface(object AeccSettingsMoveBlocksToSurface_object) 
		{
			this._i = AeccSettingsMoveBlocksToSurface_object as AeccXLandLib.IAeccSettingsMoveBlocksToSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
