namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelStatistics 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelStatistics _i;
		internal AeccParcelStatistics(object AeccParcelStatistics_object) 
		{
			this._i = AeccParcelStatistics_object as Autodesk.AECC.Interop.Land.IAeccParcelStatistics;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Perimeter => this._i.Perimeter;

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;
	}
}
