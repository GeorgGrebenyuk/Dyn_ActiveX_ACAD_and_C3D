namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateCorridor 
	{
		public AeccXRoadwayLib.IAeccSettingsCreateCorridor _i;
		internal AeccSettingsCreateCorridor(object AeccSettingsCreateCorridor_object) 
		{
			this._i = AeccSettingsCreateCorridor_object as AeccXRoadwayLib.IAeccSettingsCreateCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AssemblyInsertionDefaults => this._i.AssemblyInsertionDefaults;
	}
}
