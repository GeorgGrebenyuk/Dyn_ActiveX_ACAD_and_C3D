namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionMinorOffsetLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionMinorOffsetLabelGroup _i;
		internal AeccSectionMinorOffsetLabelGroup(object AeccSectionMinorOffsetLabelGroup_object) 
		{
			this._i = AeccSectionMinorOffsetLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccSectionMinorOffsetLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetLabelGroup => this._i.MajorOffsetLabelGroup;
	}
}
