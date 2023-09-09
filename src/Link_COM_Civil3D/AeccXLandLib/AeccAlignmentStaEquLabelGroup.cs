namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStaEquLabelGroup 
	{
		public AeccXLandLib.IAeccAlignmentStaEquLabelGroup _i;
		internal AeccAlignmentStaEquLabelGroup(object AeccAlignmentStaEquLabelGroup_object) 
		{
			this._i = AeccAlignmentStaEquLabelGroup_object as AeccXLandLib.IAeccAlignmentStaEquLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
