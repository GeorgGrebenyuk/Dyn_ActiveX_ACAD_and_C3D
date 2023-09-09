namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAssembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsAssembly _i;
		internal AeccSettingsAssembly(object AeccSettingsAssembly_object) 
		{
			this._i = AeccSettingsAssembly_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsAssembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic OffsetNameTemplate => this._i.OffsetNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic GroupNameTemplate => this._i.GroupNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
