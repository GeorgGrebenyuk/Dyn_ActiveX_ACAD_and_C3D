namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMoveTextToElevation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMoveTextToElevation _i;
		internal AeccSettingsMoveTextToElevation(object AeccSettingsMoveTextToElevation_object) 
		{
			this._i = AeccSettingsMoveTextToElevation_object as Autodesk.AECC.Interop.Land.IAeccSettingsMoveTextToElevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
