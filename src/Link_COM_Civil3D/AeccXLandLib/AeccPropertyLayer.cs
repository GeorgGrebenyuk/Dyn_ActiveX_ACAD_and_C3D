namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyLayer 
	{
		public AeccXLandLib.IAeccPropertyLayer _i;
		internal AeccPropertyLayer(object AeccPropertyLayer_object) 
		{
			this._i = AeccPropertyLayer_object as AeccXLandLib.IAeccPropertyLayer;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
