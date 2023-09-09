namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridStatistics 
	{
		public Autodesk.AECC.Interop.Land.IAeccGridStatistics _i;
		internal AeccGridStatistics(object AeccGridStatistics_object) 
		{
			this._i = AeccGridStatistics_object as Autodesk.AECC.Interop.Land.IAeccGridStatistics;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double XSpacing => this._i.XSpacing;

		///<summary>
		///
		///</summary>
		public double YSpacing => this._i.YSpacing;

		///<summary>
		///
		///</summary>
		public double Orientation => this._i.Orientation;
	}
}
