namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMoveBlocksToAttribElev 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMoveBlocksToAttribElev _i;
		internal AeccSettingsMoveBlocksToAttribElev(object AeccSettingsMoveBlocksToAttribElev_object) 
		{
			this._i = AeccSettingsMoveBlocksToAttribElev_object as Autodesk.AECC.Interop.Land.IAeccSettingsMoveBlocksToAttribElev;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
