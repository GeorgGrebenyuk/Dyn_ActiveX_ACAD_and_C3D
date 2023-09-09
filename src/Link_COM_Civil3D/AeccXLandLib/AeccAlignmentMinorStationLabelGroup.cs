namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentMinorStationLabelGroup 
	{
		public AeccXLandLib.IAeccAlignmentMinorStationLabelGroup _i;
		internal AeccAlignmentMinorStationLabelGroup(object AeccAlignmentMinorStationLabelGroup_object) 
		{
			this._i = AeccAlignmentMinorStationLabelGroup_object as AeccXLandLib.IAeccAlignmentMinorStationLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorLabelGroup => this._i.MajorLabelGroup;
	}
}
