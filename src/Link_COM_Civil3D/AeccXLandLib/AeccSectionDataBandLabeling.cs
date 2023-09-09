namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionDataBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionDataBandLabeling _i;
		internal AeccSectionDataBandLabeling(object AeccSectionDataBandLabeling_object) 
		{
			this._i = AeccSectionDataBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccSectionDataBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
