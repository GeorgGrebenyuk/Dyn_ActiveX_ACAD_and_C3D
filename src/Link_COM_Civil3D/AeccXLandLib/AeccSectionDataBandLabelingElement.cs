namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionDataBandLabelingElement 
	{
		public AeccXLandLib.IAeccSectionDataBandLabelingElement _i;
		internal AeccSectionDataBandLabelingElement(object AeccSectionDataBandLabelingElement_object) 
		{
			this._i = AeccSectionDataBandLabelingElement_object as AeccXLandLib.IAeccSectionDataBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
