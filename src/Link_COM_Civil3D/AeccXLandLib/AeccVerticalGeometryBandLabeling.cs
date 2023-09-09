namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccVerticalGeometryBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccVerticalGeometryBandLabeling _i;
		internal AeccVerticalGeometryBandLabeling(object AeccVerticalGeometryBandLabeling_object) 
		{
			this._i = AeccVerticalGeometryBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccVerticalGeometryBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
