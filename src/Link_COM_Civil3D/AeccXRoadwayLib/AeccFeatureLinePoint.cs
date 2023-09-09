namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLinePoint 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccFeatureLinePoint _i;
		internal AeccFeatureLinePoint(object AeccFeatureLinePoint_object) 
		{
			this._i = AeccFeatureLinePoint_object as Autodesk.AECC.Interop.Roadway.IAeccFeatureLinePoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public object XYZ => this._i.XYZ;

		///<summary>
		///
		///</summary>
		public bool IsBreak => this._i.IsBreak;
	}
}
