namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileMinorStationLabelGroup 
	{
		public AeccXLandLib.IAeccProfileMinorStationLabelGroup _i;
		internal AeccProfileMinorStationLabelGroup(object AeccProfileMinorStationLabelGroup_object) 
		{
			this._i = AeccProfileMinorStationLabelGroup_object as AeccXLandLib.IAeccProfileMinorStationLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelGroup => this._i.MajorStationLabelGroup;
	}
}
