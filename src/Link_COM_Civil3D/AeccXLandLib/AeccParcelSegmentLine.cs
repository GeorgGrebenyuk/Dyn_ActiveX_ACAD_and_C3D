namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentLine 
	{
		public AeccXLandLib.IAeccParcelSegmentLine _i;
		internal AeccParcelSegmentLine(object AeccParcelSegmentLine_object) 
		{
			this._i = AeccParcelSegmentLine_object as AeccXLandLib.IAeccParcelSegmentLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
