namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinStatistics 
	{
		public Autodesk.AECC.Interop.Land.IAeccTinStatistics _i;
		internal AeccTinStatistics(object AeccTinStatistics_object) 
		{
			this._i = AeccTinStatistics_object as Autodesk.AECC.Interop.Land.IAeccTinStatistics;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NumberOfTriangles => this._i.NumberOfTriangles;

		///<summary>
		///
		///</summary>
		public double MaxTriangleArea => this._i.MaxTriangleArea;

		///<summary>
		///
		///</summary>
		public double MinTriangleArea => this._i.MinTriangleArea;

		///<summary>
		///
		///</summary>
		public double MaxTriangleLength => this._i.MaxTriangleLength;

		///<summary>
		///
		///</summary>
		public double MinTriangleLength => this._i.MinTriangleLength;
	}
}
