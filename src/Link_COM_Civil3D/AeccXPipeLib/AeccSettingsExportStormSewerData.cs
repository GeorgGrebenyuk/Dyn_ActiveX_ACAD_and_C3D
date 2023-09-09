namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsExportStormSewerData 
	{
		public AeccXPipeLib.IAeccSettingsExportStormSewerData _i;
		internal AeccSettingsExportStormSewerData(object AeccSettingsExportStormSewerData_object) 
		{
			this._i = AeccSettingsExportStormSewerData_object as AeccXPipeLib.IAeccSettingsExportStormSewerData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
