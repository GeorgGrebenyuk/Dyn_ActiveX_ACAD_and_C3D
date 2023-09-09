namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentLabelGroupElement 
	{
		public AeccXLandLib.IAeccSectionSegmentLabelGroupElement _i;
		internal AeccSectionSegmentLabelGroupElement(object AeccSectionSegmentLabelGroupElement_object) 
		{
			this._i = AeccSectionSegmentLabelGroupElement_object as AeccXLandLib.IAeccSectionSegmentLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
