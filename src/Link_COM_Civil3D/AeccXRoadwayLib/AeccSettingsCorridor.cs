namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCorridor 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCorridor _i;
		internal AeccSettingsCorridor(object AeccSettingsCorridor_object) 
		{
			this._i = AeccSettingsCorridor_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentFromFeatureLineNameTemplate => this._i.AlignmentFromFeatureLineNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic ProfileFromFeatureLineNameTemplate => this._i.ProfileFromFeatureLineNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic CorridorSurfaceNameTemplate => this._i.CorridorSurfaceNameTemplate;

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
