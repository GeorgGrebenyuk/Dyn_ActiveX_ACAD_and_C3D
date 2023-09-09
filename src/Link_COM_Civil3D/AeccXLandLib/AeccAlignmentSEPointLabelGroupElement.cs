namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSEPointLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSEPointLabelGroupElement _i;
		internal AeccAlignmentSEPointLabelGroupElement(object AeccAlignmentSEPointLabelGroupElement_object) 
		{
			this._i = AeccAlignmentSEPointLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSEPointLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
