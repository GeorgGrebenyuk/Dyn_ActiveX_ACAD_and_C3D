namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelSegmentLabel _i;
		internal AeccParcelSegmentLabel(object AeccParcelSegmentLabel_object) 
		{
			this._i = AeccParcelSegmentLabel_object as Autodesk.AECC.Interop.Land.IAeccParcelSegmentLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
