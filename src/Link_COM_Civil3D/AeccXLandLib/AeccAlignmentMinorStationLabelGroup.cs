namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentMinorStationLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentMinorStationLabelGroup _i;
		internal AeccAlignmentMinorStationLabelGroup(object AeccAlignmentMinorStationLabelGroup_object) 
		{
			this._i = AeccAlignmentMinorStationLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentMinorStationLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorLabelGroup => this._i.MajorLabelGroup;
	}
}
