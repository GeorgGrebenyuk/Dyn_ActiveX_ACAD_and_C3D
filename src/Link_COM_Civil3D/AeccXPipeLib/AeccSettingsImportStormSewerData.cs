namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportStormSewerData 
	{
		public AeccXPipeLib.IAeccSettingsImportStormSewerData _i;
		internal AeccSettingsImportStormSewerData(object AeccSettingsImportStormSewerData_object) 
		{
			this._i = AeccSettingsImportStormSewerData_object as AeccXPipeLib.IAeccSettingsImportStormSewerData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
