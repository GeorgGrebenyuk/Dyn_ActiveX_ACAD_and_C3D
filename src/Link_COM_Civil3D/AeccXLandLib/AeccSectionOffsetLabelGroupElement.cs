namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionOffsetLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionOffsetLabelGroupElement _i;
		internal AeccSectionOffsetLabelGroupElement(object AeccSectionOffsetLabelGroupElement_object) 
		{
			this._i = AeccSectionOffsetLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccSectionOffsetLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
