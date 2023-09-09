namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrameLabelGroup 
	{
		public AeccXLandLib.IAeccViewFrameLabelGroup _i;
		internal AeccViewFrameLabelGroup(object AeccViewFrameLabelGroup_object) 
		{
			this._i = AeccViewFrameLabelGroup_object as AeccXLandLib.IAeccViewFrameLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
