namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworkBandLabeling 
	{
		public AeccXLandLib.IAeccPipeNetworkBandLabeling _i;
		internal AeccPipeNetworkBandLabeling(object AeccPipeNetworkBandLabeling_object) 
		{
			this._i = AeccPipeNetworkBandLabeling_object as AeccXLandLib.IAeccPipeNetworkBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
