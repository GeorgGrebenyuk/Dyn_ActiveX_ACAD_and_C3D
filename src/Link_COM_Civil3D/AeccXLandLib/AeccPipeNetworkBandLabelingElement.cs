namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworkBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccPipeNetworkBandLabelingElement _i;
		internal AeccPipeNetworkBandLabelingElement(object AeccPipeNetworkBandLabelingElement_object) 
		{
			this._i = AeccPipeNetworkBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccPipeNetworkBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
