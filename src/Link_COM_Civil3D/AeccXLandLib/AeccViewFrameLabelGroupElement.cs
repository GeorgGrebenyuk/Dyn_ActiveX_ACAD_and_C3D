namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrameLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccViewFrameLabelGroupElement _i;
		internal AeccViewFrameLabelGroupElement(object AeccViewFrameLabelGroupElement_object) 
		{
			this._i = AeccViewFrameLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccViewFrameLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
