namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSamplelineLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSamplelineLabelGroupElement _i;
		internal AeccSamplelineLabelGroupElement(object AeccSamplelineLabelGroupElement_object) 
		{
			this._i = AeccSamplelineLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccSamplelineLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
