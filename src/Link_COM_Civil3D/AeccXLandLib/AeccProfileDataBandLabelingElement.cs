namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileDataBandLabelingElement 
	{
		public AeccXLandLib.IAeccProfileDataBandLabelingElement _i;
		internal AeccProfileDataBandLabelingElement(object AeccProfileDataBandLabelingElement_object) 
		{
			this._i = AeccProfileDataBandLabelingElement_object as AeccXLandLib.IAeccProfileDataBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
