namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelSegmentLine _i;
		internal AeccParcelSegmentLine(object AeccParcelSegmentLine_object) 
		{
			this._i = AeccParcelSegmentLine_object as Autodesk.AECC.Interop.Land.IAeccParcelSegmentLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
