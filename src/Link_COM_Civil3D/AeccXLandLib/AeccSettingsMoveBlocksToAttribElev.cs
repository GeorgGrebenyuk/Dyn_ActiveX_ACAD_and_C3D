namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMoveBlocksToAttribElev 
	{
		public AeccXLandLib.IAeccSettingsMoveBlocksToAttribElev _i;
		internal AeccSettingsMoveBlocksToAttribElev(object AeccSettingsMoveBlocksToAttribElev_object) 
		{
			this._i = AeccSettingsMoveBlocksToAttribElev_object as AeccXLandLib.IAeccSettingsMoveBlocksToAttribElev;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
