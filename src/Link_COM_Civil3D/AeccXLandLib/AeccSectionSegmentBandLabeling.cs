namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionSegmentBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionSegmentBandLabeling _i;
		internal AeccSectionSegmentBandLabeling(object AeccSectionSegmentBandLabeling_object) 
		{
			this._i = AeccSectionSegmentBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccSectionSegmentBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
