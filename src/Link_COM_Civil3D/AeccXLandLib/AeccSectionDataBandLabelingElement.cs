namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionDataBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionDataBandLabelingElement _i;
		internal AeccSectionDataBandLabelingElement(object AeccSectionDataBandLabelingElement_object) 
		{
			this._i = AeccSectionDataBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccSectionDataBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
