namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStaEquLabelGroupElement 
	{
		public AeccXLandLib.IAeccAlignmentStaEquLabelGroupElement _i;
		internal AeccAlignmentStaEquLabelGroupElement(object AeccAlignmentStaEquLabelGroupElement_object) 
		{
			this._i = AeccAlignmentStaEquLabelGroupElement_object as AeccXLandLib.IAeccAlignmentStaEquLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
