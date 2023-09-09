namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMatchLineLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccMatchLineLabelGroupElement _i;
		internal AeccMatchLineLabelGroupElement(object AeccMatchLineLabelGroupElement_object) 
		{
			this._i = AeccMatchLineLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccMatchLineLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
