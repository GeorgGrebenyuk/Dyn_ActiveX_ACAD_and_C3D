namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentGeomPointLabelGroupElement 
	{
		public AeccXLandLib.IAeccAlignmentGeomPointLabelGroupElement _i;
		internal AeccAlignmentGeomPointLabelGroupElement(object AeccAlignmentGeomPointLabelGroupElement_object) 
		{
			this._i = AeccAlignmentGeomPointLabelGroupElement_object as AeccXLandLib.IAeccAlignmentGeomPointLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
