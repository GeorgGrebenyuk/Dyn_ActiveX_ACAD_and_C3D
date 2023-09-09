namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAssemblyTool 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateAssemblyTool _i;
		internal AeccSettingsCreateAssemblyTool(object AeccSettingsCreateAssemblyTool_object) 
		{
			this._i = AeccSettingsCreateAssemblyTool_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateAssemblyTool;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
