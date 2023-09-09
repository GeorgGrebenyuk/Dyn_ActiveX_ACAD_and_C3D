namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentLabelGroupElement _i;
		internal AeccAlignmentLabelGroupElement(object AeccAlignmentLabelGroupElement_object) 
		{
			this._i = AeccAlignmentLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccAlignmentLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
