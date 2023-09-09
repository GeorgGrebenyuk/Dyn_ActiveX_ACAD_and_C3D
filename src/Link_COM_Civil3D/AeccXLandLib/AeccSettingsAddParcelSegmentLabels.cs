namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelSegmentLabels 
	{
		public AeccXLandLib.IAeccSettingsAddParcelSegmentLabels _i;
		internal AeccSettingsAddParcelSegmentLabels(object AeccSettingsAddParcelSegmentLabels_object) 
		{
			this._i = AeccSettingsAddParcelSegmentLabels_object as AeccXLandLib.IAeccSettingsAddParcelSegmentLabels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelingDirection => this._i.LabelingDirection;
	}
}
