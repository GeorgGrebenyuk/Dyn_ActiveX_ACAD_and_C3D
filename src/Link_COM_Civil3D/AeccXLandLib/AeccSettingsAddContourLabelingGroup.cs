namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddContourLabelingGroup 
	{
		public AeccXLandLib.IAeccSettingsAddContourLabelingGroup _i;
		internal AeccSettingsAddContourLabelingGroup(object AeccSettingsAddContourLabelingGroup_object) 
		{
			this._i = AeccSettingsAddContourLabelingGroup_object as AeccXLandLib.IAeccSettingsAddContourLabelingGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Intervalalongcontour => this._i.Intervalalongcontour;
	}
}
