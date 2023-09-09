namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStationLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentStationLabelGroupElement _i;
		internal AeccAlignmentStationLabelGroupElement(object AeccAlignmentStationLabelGroupElement_object) 
		{
			this._i = AeccAlignmentStationLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccAlignmentStationLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
