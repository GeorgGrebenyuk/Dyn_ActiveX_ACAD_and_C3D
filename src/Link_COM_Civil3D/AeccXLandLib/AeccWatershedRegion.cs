namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegion 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedRegion _i;
		internal AeccWatershedRegion(object AeccWatershedRegion_object) 
		{
			this._i = AeccWatershedRegion_object as Autodesk.AECC.Interop.Land.IAeccWatershedRegion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Id => this._i.Id;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public object BoundaryLine => this._i.BoundaryLine;
	}
}
