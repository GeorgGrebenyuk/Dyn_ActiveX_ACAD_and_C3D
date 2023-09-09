namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileDataBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileDataBandLabeling _i;
		internal AeccProfileDataBandLabeling(object AeccProfileDataBandLabeling_object) 
		{
			this._i = AeccProfileDataBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccProfileDataBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
