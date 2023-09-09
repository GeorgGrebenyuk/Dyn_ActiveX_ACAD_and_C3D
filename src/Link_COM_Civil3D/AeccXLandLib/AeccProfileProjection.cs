namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileProjection 
	{
		public AeccXLandLib.IAeccProfileProjection _i;
		internal AeccProfileProjection(object AeccProfileProjection_object) 
		{
			this._i = AeccProfileProjection_object as AeccXLandLib.IAeccProfileProjection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
