namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworkBandLabelingElement 
	{
		public AeccXLandLib.IAeccPipeNetworkBandLabelingElement _i;
		internal AeccPipeNetworkBandLabelingElement(object AeccPipeNetworkBandLabelingElement_object) 
		{
			this._i = AeccPipeNetworkBandLabelingElement_object as AeccXLandLib.IAeccPipeNetworkBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
