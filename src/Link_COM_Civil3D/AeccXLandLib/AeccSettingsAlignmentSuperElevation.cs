namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAlignmentSuperElevation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAlignmentSuperElevation _i;
		internal AeccSettingsAlignmentSuperElevation(object AeccSettingsAlignmentSuperElevation_object) 
		{
			this._i = AeccSettingsAlignmentSuperElevation_object as Autodesk.AECC.Interop.Land.IAeccSettingsAlignmentSuperElevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CorridorType => this._i.CorridorType;

		///<summary>
		///
		///</summary>
		public dynamic CrossSectionShape => this._i.CrossSectionShape;

		///<summary>
		///
		///</summary>
		public dynamic HighsideLocation => this._i.HighsideLocation;

		///<summary>
		///
		///</summary>
		public dynamic NominalWidth => this._i.NominalWidth;

		///<summary>
		///
		///</summary>
		public dynamic NormalLaneSlope => this._i.NormalLaneSlope;

		///<summary>
		///
		///</summary>
		public dynamic NormalShoulderSlope => this._i.NormalShoulderSlope;

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeedLookupMethod => this._i.DesignSpeedLookupMethod;

		///<summary>
		///
		///</summary>
		public dynamic RadiusLookupMethod => this._i.RadiusLookupMethod;

		///<summary>
		///
		///</summary>
		public dynamic OutsideShoulderMethod => this._i.OutsideShoulderMethod;

		///<summary>
		///
		///</summary>
		public dynamic InsideShoulderMethod => this._i.InsideShoulderMethod;

		///<summary>
		///
		///</summary>
		public dynamic StationRoundingOption => this._i.StationRoundingOption;
	}
}
