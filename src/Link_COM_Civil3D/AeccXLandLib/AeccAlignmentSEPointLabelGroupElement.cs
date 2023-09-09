namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSEPointLabelGroupElement 
	{
		public AeccXLandLib.IAeccAlignmentSEPointLabelGroupElement _i;
		internal AeccAlignmentSEPointLabelGroupElement(object AeccAlignmentSEPointLabelGroupElement_object) 
		{
			this._i = AeccAlignmentSEPointLabelGroupElement_object as AeccXLandLib.IAeccAlignmentSEPointLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
