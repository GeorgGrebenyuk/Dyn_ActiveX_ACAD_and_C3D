namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccVerticalGeometryBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccVerticalGeometryBandLabelingElement _i;
		internal AeccVerticalGeometryBandLabelingElement(object AeccVerticalGeometryBandLabelingElement_object) 
		{
			this._i = AeccVerticalGeometryBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccVerticalGeometryBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
