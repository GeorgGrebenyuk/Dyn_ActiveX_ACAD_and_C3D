namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentLabelGroup 
	{
		public AeccXLandLib.IAeccSectionSegmentLabelGroup _i;
		internal AeccSectionSegmentLabelGroup(object AeccSectionSegmentLabelGroup_object) 
		{
			this._i = AeccSectionSegmentLabelGroup_object as AeccXLandLib.IAeccSectionSegmentLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
