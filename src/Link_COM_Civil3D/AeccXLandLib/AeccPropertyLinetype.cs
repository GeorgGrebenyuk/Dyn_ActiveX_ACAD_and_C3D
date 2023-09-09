namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyLinetype 
	{
		public AeccXLandLib.IAeccPropertyLinetype _i;
		internal AeccPropertyLinetype(object AeccPropertyLinetype_object) 
		{
			this._i = AeccPropertyLinetype_object as AeccXLandLib.IAeccPropertyLinetype;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
