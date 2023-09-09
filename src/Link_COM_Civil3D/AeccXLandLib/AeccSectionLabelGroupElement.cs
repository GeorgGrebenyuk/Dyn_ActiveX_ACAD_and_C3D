namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionLabelGroupElement _i;
		internal AeccSectionLabelGroupElement(object AeccSectionLabelGroupElement_object) 
		{
			this._i = AeccSectionLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccSectionLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
