namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAmbient 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAmbient _i;
		internal AeccSettingsAmbient(object AeccSettingsAmbient_object) 
		{
			this._i = AeccSettingsAmbient_object as Autodesk.AECC.Interop.Land.IAeccSettingsAmbient;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GeneralSettings => this._i.GeneralSettings;

		///<summary>
		///
		///</summary>
		public dynamic LabelingSettings => this._i.LabelingSettings;

		///<summary>
		///
		///</summary>
		public dynamic UnitlessSettings => this._i.UnitlessSettings;

		///<summary>
		///
		///</summary>
		public dynamic CoordinateSettings => this._i.CoordinateSettings;

		///<summary>
		///
		///</summary>
		public dynamic DistanceSettings => this._i.DistanceSettings;

		///<summary>
		///
		///</summary>
		public dynamic DimensionSettings => this._i.DimensionSettings;

		///<summary>
		///
		///</summary>
		public dynamic ElevationSettings => this._i.ElevationSettings;

		///<summary>
		///
		///</summary>
		public dynamic AreaSettings => this._i.AreaSettings;

		///<summary>
		///
		///</summary>
		public dynamic VolumeSettings => this._i.VolumeSettings;

		///<summary>
		///
		///</summary>
		public dynamic AngleSettings => this._i.AngleSettings;

		///<summary>
		///
		///</summary>
		public dynamic DirectionSettings => this._i.DirectionSettings;

		///<summary>
		///
		///</summary>
		public dynamic LatLongSettings => this._i.LatLongSettings;

		///<summary>
		///
		///</summary>
		public dynamic GradeSlopeSettings => this._i.GradeSlopeSettings;

		///<summary>
		///
		///</summary>
		public dynamic TransparentCommandSettings => this._i.TransparentCommandSettings;

		///<summary>
		///
		///</summary>
		public dynamic StationSettings => this._i.StationSettings;

		///<summary>
		///
		///</summary>
		public dynamic GridCoordinateSettings => this._i.GridCoordinateSettings;
	}
}
