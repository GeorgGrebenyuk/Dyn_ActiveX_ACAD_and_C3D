namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelGroupElement 
	{
		public AeccXLandLib.IAeccAlignmentLabelGroupElement _i;
		internal AeccAlignmentLabelGroupElement(object AeccAlignmentLabelGroupElement_object) 
		{
			this._i = AeccAlignmentLabelGroupElement_object as AeccXLandLib.IAeccAlignmentLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
