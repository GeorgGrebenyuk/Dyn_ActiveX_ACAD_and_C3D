namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSubAssemblyTool 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateSubAssemblyTool _i;
		internal AeccSettingsCreateSubAssemblyTool(object AeccSettingsCreateSubAssemblyTool_object) 
		{
			this._i = AeccSettingsCreateSubAssemblyTool_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateSubAssemblyTool;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
