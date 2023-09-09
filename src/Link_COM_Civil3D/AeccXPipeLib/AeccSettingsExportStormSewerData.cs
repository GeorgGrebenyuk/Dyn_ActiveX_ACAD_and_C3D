namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsExportStormSewerData 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsExportStormSewerData _i;
		internal AeccSettingsExportStormSewerData(object AeccSettingsExportStormSewerData_object) 
		{
			this._i = AeccSettingsExportStormSewerData_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsExportStormSewerData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
