namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionSegmentLabelGroupElement _i;
		internal AeccSectionSegmentLabelGroupElement(object AeccSectionSegmentLabelGroupElement_object) 
		{
			this._i = AeccSectionSegmentLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccSectionSegmentLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
