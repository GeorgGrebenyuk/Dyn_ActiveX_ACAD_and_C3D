namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionSegmentBandLabelingElement _i;
		internal AeccSectionSegmentBandLabelingElement(object AeccSectionSegmentBandLabelingElement_object) 
		{
			this._i = AeccSectionSegmentBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccSectionSegmentBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
