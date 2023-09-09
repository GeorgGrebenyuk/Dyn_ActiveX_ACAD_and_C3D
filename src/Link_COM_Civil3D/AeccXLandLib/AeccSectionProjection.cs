namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionProjection 
	{
		public AeccXLandLib.IAeccSectionProjection _i;
		internal AeccSectionProjection(object AeccSectionProjection_object) 
		{
			this._i = AeccSectionProjection_object as AeccXLandLib.IAeccSectionProjection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
