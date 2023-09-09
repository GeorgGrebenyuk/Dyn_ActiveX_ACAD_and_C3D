namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelGroupElement _i;
		internal AeccLabelGroupElement(object AeccLabelGroupElement_object) 
		{
			this._i = AeccLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
