namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionMinorOffsetLabelGroup 
	{
		public AeccXLandLib.IAeccSectionMinorOffsetLabelGroup _i;
		internal AeccSectionMinorOffsetLabelGroup(object AeccSectionMinorOffsetLabelGroup_object) 
		{
			this._i = AeccSectionMinorOffsetLabelGroup_object as AeccXLandLib.IAeccSectionMinorOffsetLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetLabelGroup => this._i.MajorOffsetLabelGroup;
	}
}
