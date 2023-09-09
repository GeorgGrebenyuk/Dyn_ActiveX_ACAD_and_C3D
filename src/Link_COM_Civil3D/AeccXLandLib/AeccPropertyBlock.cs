namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyBlock 
	{
		public AeccXLandLib.IAeccPropertyBlock _i;
		internal AeccPropertyBlock(object AeccPropertyBlock_object) 
		{
			this._i = AeccPropertyBlock_object as AeccXLandLib.IAeccPropertyBlock;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
