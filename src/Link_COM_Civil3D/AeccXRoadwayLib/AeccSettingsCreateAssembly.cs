namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAssembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateAssembly _i;
		internal AeccSettingsCreateAssembly(object AeccSettingsCreateAssembly_object) 
		{
			this._i = AeccSettingsCreateAssembly_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateAssembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
