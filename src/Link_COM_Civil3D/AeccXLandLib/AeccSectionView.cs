namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionView _i;
		internal AeccSectionView(object AeccSectionView_object) 
		{
			this._i = AeccSectionView_object as Autodesk.AECC.Interop.Land.IAeccSectionView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///
		///</summary>
		public void Set_Style(object pVal) 
		{
			this._i.Style = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public double LengthLeft => this._i.LengthLeft;

		///<summary>
		///
		///</summary>
		public double LengthRight => this._i.LengthRight;

		///<summary>
		///
		///</summary>
		public double OffsetLeft => this._i.OffsetLeft;

		///<summary>
		///
		///</summary>
		public double OffsetRight => this._i.OffsetRight;

		///<summary>
		///
		///</summary>
		public double ElevationMin => this._i.ElevationMin;

		///<summary>
		///
		///</summary>
		public double ElevationMax => this._i.ElevationMax;

		///<summary>
		///
		///</summary>
		public dynamic BandSet => this._i.BandSet;

		///<summary>
		///
		///</summary>
		public dynamic Overrides => this._i.Overrides;

		///<summary>
		///
		///</summary>
		public void FindStationOffsetAndElevationAtXY(double X,double Y,out double Station,out double Offset,out double Elevation,out object pInBounds) 
		{
			this._i.FindStationOffsetAndElevationAtXY(X,Y,out Station,out Offset,out Elevation,out pInBounds);
		}

		///<summary>
		///
		///</summary>
		public void FindXYAtStationOffsetAndElevation(double Station,double Offset,double Elevation,out double X,out double Y,out object pInBounds) 
		{
			this._i.FindXYAtStationOffsetAndElevation(Station,Offset,Elevation,out X,out Y,out pInBounds);
		}
	}
}
