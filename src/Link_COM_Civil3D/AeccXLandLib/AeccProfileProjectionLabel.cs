namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileProjectionLabel 
	{
		public AeccXLandLib.IAeccProfileProjectionLabel _i;
		internal AeccProfileProjectionLabel(object AeccProfileProjectionLabel_object) 
		{
			this._i = AeccProfileProjectionLabel_object as AeccXLandLib.IAeccProfileProjectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
