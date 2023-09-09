namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStationLabelGroupElement 
	{
		public AeccXLandLib.IAeccAlignmentStationLabelGroupElement _i;
		internal AeccAlignmentStationLabelGroupElement(object AeccAlignmentStationLabelGroupElement_object) 
		{
			this._i = AeccAlignmentStationLabelGroupElement_object as AeccXLandLib.IAeccAlignmentStationLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
