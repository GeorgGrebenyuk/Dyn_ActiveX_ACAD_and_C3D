namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionDataBandLabeling 
	{
		public AeccXLandLib.IAeccSectionDataBandLabeling _i;
		internal AeccSectionDataBandLabeling(object AeccSectionDataBandLabeling_object) 
		{
			this._i = AeccSectionDataBandLabeling_object as AeccXLandLib.IAeccSectionDataBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
