namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentLabel 
	{
		public AeccXLandLib.IAeccParcelSegmentLabel _i;
		internal AeccParcelSegmentLabel(object AeccParcelSegmentLabel_object) 
		{
			this._i = AeccParcelSegmentLabel_object as AeccXLandLib.IAeccParcelSegmentLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
