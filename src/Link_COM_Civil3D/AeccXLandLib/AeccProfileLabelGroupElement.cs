namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileLabelGroupElement _i;
		internal AeccProfileLabelGroupElement(object AeccProfileLabelGroupElement_object) 
		{
			this._i = AeccProfileLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccProfileLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
