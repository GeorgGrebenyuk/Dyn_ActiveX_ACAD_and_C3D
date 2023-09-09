namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAdditionalSampleControls 
	{
		public AeccXLandLib.IAeccSettingsAdditionalSampleControls _i;
		internal AeccSettingsAdditionalSampleControls(object AeccSettingsAdditionalSampleControls_object) 
		{
			this._i = AeccSettingsAdditionalSampleControls_object as AeccXLandLib.IAeccSettingsAdditionalSampleControls;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AtRangeStart => this._i.AtRangeStart;

		///<summary>
		///
		///</summary>
		public dynamic AtRangeEnd => this._i.AtRangeEnd;

		///<summary>
		///
		///</summary>
		public dynamic AtHorizontalGeometryPoints => this._i.AtHorizontalGeometryPoints;

		///<summary>
		///
		///</summary>
		public dynamic AtSuperelevationCriticalStations => this._i.AtSuperelevationCriticalStations;

		///<summary>
		///
		///</summary>
		public dynamic StartAtAlignStart => this._i.StartAtAlignStart;

		///<summary>
		///
		///</summary>
		public dynamic EndAtAlignEnd => this._i.EndAtAlignEnd;
	}
}
