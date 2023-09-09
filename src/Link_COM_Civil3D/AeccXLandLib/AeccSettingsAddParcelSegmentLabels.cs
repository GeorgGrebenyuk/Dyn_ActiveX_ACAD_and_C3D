namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddParcelSegmentLabels 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelSegmentLabels _i;
		internal AeccSettingsAddParcelSegmentLabels(object AeccSettingsAddParcelSegmentLabels_object) 
		{
			this._i = AeccSettingsAddParcelSegmentLabels_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddParcelSegmentLabels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelingDirection => this._i.LabelingDirection;
	}
}
