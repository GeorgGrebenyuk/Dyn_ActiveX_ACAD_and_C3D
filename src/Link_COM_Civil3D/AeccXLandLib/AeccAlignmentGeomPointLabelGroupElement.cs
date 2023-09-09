namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentGeomPointLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentGeomPointLabelGroupElement _i;
		internal AeccAlignmentGeomPointLabelGroupElement(object AeccAlignmentGeomPointLabelGroupElement_object) 
		{
			this._i = AeccAlignmentGeomPointLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccAlignmentGeomPointLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
