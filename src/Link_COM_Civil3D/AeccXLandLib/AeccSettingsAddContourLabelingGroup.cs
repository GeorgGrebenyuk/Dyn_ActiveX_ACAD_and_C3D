namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddContourLabelingGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddContourLabelingGroup _i;
		internal AeccSettingsAddContourLabelingGroup(object AeccSettingsAddContourLabelingGroup_object) 
		{
			this._i = AeccSettingsAddContourLabelingGroup_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddContourLabelingGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Intervalalongcontour => this._i.Intervalalongcontour;
	}
}
