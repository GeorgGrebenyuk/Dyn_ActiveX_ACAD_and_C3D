namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileView 
	{
		public AeccXLandLib.IAeccProfileView _i;
		internal AeccProfileView(object AeccProfileView_object) 
		{
			this._i = AeccProfileView_object as AeccXLandLib.IAeccProfileView;
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
		public void Set_StationStart(double pVal) 
		{
			this._i.StationStart = pVal;
		}

		///<summary>
		///
		///</summary>
		public double StationStart => this._i.StationStart;

		///<summary>
		///
		///</summary>
		public void Set_StationEnd(double pVal) 
		{
			this._i.StationEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public double StationEnd => this._i.StationEnd;

		///<summary>
		///
		///</summary>
		public void Set_StationLocked(bool pVal) 
		{
			this._i.StationLocked = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool StationLocked => this._i.StationLocked;

		///<summary>
		///
		///</summary>
		public void Set_ElevationMin(double pVal) 
		{
			this._i.ElevationMin = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ElevationMin => this._i.ElevationMin;

		///<summary>
		///
		///</summary>
		public void Set_ElevationMax(double pVal) 
		{
			this._i.ElevationMax = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ElevationMax => this._i.ElevationMax;

		///<summary>
		///
		///</summary>
		public void Set_ElevationLocked(bool pVal) 
		{
			this._i.ElevationLocked = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ElevationLocked => this._i.ElevationLocked;

		///<summary>
		///
		///</summary>
		public dynamic Overrides => this._i.Overrides;

		///<summary>
		///
		///</summary>
		public void FindStationAndElevationAtXY(double X,double Y,out double pStation,out double pElevation,out object pInBounds) 
		{
			this._i.FindStationAndElevationAtXY(X,Y,out pStation,out pElevation,out pInBounds);
		}

		///<summary>
		///
		///</summary>
		public void FindXYAtStationAndElevation(double Station,double Elevation,out double pX,out double pY,out object pInBounds) 
		{
			this._i.FindXYAtStationAndElevation(Station,Elevation,out pX,out pY,out pInBounds);
		}

		///<summary>
		///
		///</summary>
		public dynamic BandSet => this._i.BandSet;

		///<summary>
		///
		///</summary>
		public dynamic Labels => this._i.Labels;
	}
}
