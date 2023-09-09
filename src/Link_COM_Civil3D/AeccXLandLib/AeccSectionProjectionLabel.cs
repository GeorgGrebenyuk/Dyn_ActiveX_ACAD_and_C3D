namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionProjectionLabel 
	{
		public AeccXLandLib.IAeccSectionProjectionLabel _i;
		internal AeccSectionProjectionLabel(object AeccSectionProjectionLabel_object) 
		{
			this._i = AeccSectionProjectionLabel_object as AeccXLandLib.IAeccSectionProjectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
