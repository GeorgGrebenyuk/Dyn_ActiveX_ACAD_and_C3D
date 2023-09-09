namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandSuperElevationStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccBandSuperElevationStyles _i;
		internal AeccBandSuperElevationStyles(object AeccBandSuperElevationStyles_object) 
		{
			this._i = AeccBandSuperElevationStyles_object as Autodesk.AECC.Interop.Land.IAeccBandSuperElevationStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
