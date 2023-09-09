namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsViewFrameCreation 
	{
		public AeccXLandLib.IAeccSettingsViewFrameCreation _i;
		internal AeccSettingsViewFrameCreation(object AeccSettingsViewFrameCreation_object) 
		{
			this._i = AeccSettingsViewFrameCreation_object as AeccXLandLib.IAeccSettingsViewFrameCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpecifyAlignStationRange => this._i.SpecifyAlignStationRange;

		///<summary>
		///
		///</summary>
		public dynamic SheetType => this._i.SheetType;

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameOrientation => this._i.ViewFrameOrientation;

		///<summary>
		///
		///</summary>
		public dynamic EnableFirstViewFrameOffset => this._i.EnableFirstViewFrameOffset;

		///<summary>
		///
		///</summary>
		public dynamic FirstViewFrameOffsetDistance => this._i.FirstViewFrameOffsetDistance;

		///<summary>
		///
		///</summary>
		public dynamic InsertMatchLines => this._i.InsertMatchLines;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineSnapStation => this._i.MatchLineSnapStation;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineSnapStationValue => this._i.MatchLineSnapStationValue;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineRepositioning => this._i.MatchLineRepositioning;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineRepositioningValue => this._i.MatchLineRepositioningValue;
	}
}
