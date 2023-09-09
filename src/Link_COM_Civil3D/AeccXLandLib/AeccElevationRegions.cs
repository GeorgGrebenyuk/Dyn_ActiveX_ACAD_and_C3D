namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccElevationRegions 
	{
		public Autodesk.AECC.Interop.Land.IAeccElevationRegions _i;
		internal AeccElevationRegions(object AeccElevationRegions_object) 
		{
			this._i = AeccElevationRegions_object as Autodesk.AECC.Interop.Land.IAeccElevationRegions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}
	}
}
