namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMoveTextToElevation 
	{
		public AeccXLandLib.IAeccSettingsMoveTextToElevation _i;
		internal AeccSettingsMoveTextToElevation(object AeccSettingsMoveTextToElevation_object) 
		{
			this._i = AeccSettingsMoveTextToElevation_object as AeccXLandLib.IAeccSettingsMoveTextToElevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
