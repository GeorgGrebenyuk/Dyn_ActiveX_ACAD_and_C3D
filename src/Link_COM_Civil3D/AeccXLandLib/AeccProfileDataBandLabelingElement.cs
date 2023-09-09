namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileDataBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileDataBandLabelingElement _i;
		internal AeccProfileDataBandLabelingElement(object AeccProfileDataBandLabelingElement_object) 
		{
			this._i = AeccProfileDataBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccProfileDataBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
