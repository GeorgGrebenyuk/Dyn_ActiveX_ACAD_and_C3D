namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentMinorStationLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentMinorStationLabelGroupElement _i;
		internal AeccAlignmentMinorStationLabelGroupElement(object AeccAlignmentMinorStationLabelGroupElement_object) 
		{
			this._i = AeccAlignmentMinorStationLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccAlignmentMinorStationLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
