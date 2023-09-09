namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSimpleCorridor 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateSimpleCorridor _i;
		internal AeccSettingsCreateSimpleCorridor(object AeccSettingsCreateSimpleCorridor_object) 
		{
			this._i = AeccSettingsCreateSimpleCorridor_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateSimpleCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AssemblyInsertionDefaults => this._i.AssemblyInsertionDefaults;
	}
}
