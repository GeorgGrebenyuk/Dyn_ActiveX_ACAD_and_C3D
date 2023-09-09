namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentBandLabelingElement 
	{
		public AeccXLandLib.IAeccSectionSegmentBandLabelingElement _i;
		internal AeccSectionSegmentBandLabelingElement(object AeccSectionSegmentBandLabelingElement_object) 
		{
			this._i = AeccSectionSegmentBandLabelingElement_object as AeccXLandLib.IAeccSectionSegmentBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
