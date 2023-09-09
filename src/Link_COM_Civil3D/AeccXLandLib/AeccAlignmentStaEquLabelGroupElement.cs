namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStaEquLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentStaEquLabelGroupElement _i;
		internal AeccAlignmentStaEquLabelGroupElement(object AeccAlignmentStaEquLabelGroupElement_object) 
		{
			this._i = AeccAlignmentStaEquLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccAlignmentStaEquLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
