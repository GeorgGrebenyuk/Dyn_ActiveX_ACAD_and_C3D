namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentLabels 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelSegmentLabels _i;
		internal AeccParcelSegmentLabels(object AeccParcelSegmentLabels_object) 
		{
			this._i = AeccParcelSegmentLabels_object as Autodesk.AECC.Interop.Land.IAeccParcelSegmentLabels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(object LineLabelStyle,object CurveLabelStyle,object locationPt) 
		{
			return this._i.Add(LineLabelStyle,CurveLabelStyle,locationPt);
		}
	}
}
