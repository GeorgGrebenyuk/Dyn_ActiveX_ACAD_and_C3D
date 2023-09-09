namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionSegmentLabelGroup _i;
		internal AeccSectionSegmentLabelGroup(object AeccSectionSegmentLabelGroup_object) 
		{
			this._i = AeccSectionSegmentLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccSectionSegmentLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
