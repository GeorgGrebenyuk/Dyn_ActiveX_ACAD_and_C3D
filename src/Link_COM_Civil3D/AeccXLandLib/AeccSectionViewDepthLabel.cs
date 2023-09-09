namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewDepthLabel 
	{
		public AeccXLandLib.IAeccSectionViewDepthLabel _i;
		internal AeccSectionViewDepthLabel(object AeccSectionViewDepthLabel_object) 
		{
			this._i = AeccSectionViewDepthLabel_object as AeccXLandLib.IAeccSectionViewDepthLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
