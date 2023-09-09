namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccHorizontalGeometryBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccHorizontalGeometryBandLabelingElement _i;
		internal AeccHorizontalGeometryBandLabelingElement(object AeccHorizontalGeometryBandLabelingElement_object) 
		{
			this._i = AeccHorizontalGeometryBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccHorizontalGeometryBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
