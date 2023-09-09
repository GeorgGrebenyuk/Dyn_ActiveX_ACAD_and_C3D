namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworkBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccPipeNetworkBandLabeling _i;
		internal AeccPipeNetworkBandLabeling(object AeccPipeNetworkBandLabeling_object) 
		{
			this._i = AeccPipeNetworkBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccPipeNetworkBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
