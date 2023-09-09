namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLineLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileLineLabelGroupElement _i;
		internal AeccProfileLineLabelGroupElement(object AeccProfileLineLabelGroupElement_object) 
		{
			this._i = AeccProfileLineLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccProfileLineLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
