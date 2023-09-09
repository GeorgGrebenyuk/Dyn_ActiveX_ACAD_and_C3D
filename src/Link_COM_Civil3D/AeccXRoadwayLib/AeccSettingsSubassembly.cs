namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSubassembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsSubassembly _i;
		internal AeccSettingsSubassembly(object AeccSettingsSubassembly_object) 
		{
			this._i = AeccSettingsSubassembly_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsSubassembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateFromMacroNameTemplate => this._i.CreateFromMacroNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic CreateFromEntitiesNameTemplate => this._i.CreateFromEntitiesNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic CodeSetStyle => this._i.CodeSetStyle;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
