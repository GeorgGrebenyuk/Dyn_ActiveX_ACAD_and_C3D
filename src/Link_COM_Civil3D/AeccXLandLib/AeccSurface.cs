namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurface 
	{
		public AeccXLandLib.IAeccSurface _i;
		internal AeccSurface(object AeccSurface_object) 
		{
			this._i = AeccSurface_object as AeccXLandLib.IAeccSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

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
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Boundaries => this._i.Boundaries;

		///<summary>
		///
		///</summary>
		public double FindElevationAtXY(double X,double Y) 
		{
			return this._i.FindElevationAtXY(X,Y);
		}

		///<summary>
		///
		///</summary>
		public object IntersectPointWithSurface(object StartPoint,object dir) 
		{
			return this._i.IntersectPointWithSurface(StartPoint,dir);
		}

		///<summary>
		///
		///</summary>
		public void Rebuild() 
		{
			this._i.Rebuild();
		}

		///<summary>
		///
		///</summary>
		public object SampleElevations(double StartX,double StartY,double EndX,double EndY) 
		{
			return this._i.SampleElevations(StartX,StartY,EndX,EndY);
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfaceAnalysis => this._i.SurfaceAnalysis;

		///<summary>
		///
		///</summary>
		public object Points => this._i.Points;

		///<summary>
		///
		///</summary>
		public void CreateSnapshot() 
		{
			this._i.CreateSnapshot();
		}

		///<summary>
		///
		///</summary>
		public void RemoveSnapshot() 
		{
			this._i.RemoveSnapshot();
		}

		///<summary>
		///
		///</summary>
		public void RebuildSnapshot() 
		{
			this._i.RebuildSnapshot();
		}

		///<summary>
		///
		///</summary>
		public dynamic ContourLabelGroups => this._i.ContourLabelGroups;

		///<summary>
		///
		///</summary>
		public dynamic Labels => this._i.Labels;

		///<summary>
		///
		///</summary>
		public object ExtractBorder(AeccXLandLib.AeccDisplayOrientation ViewType) 
		{
			return this._i.ExtractBorder(ViewType);
		}

		///<summary>
		///
		///</summary>
		public object ExtractContour(AeccXLandLib.AeccDisplayOrientation ViewType,AeccXLandLib.AeccSurfaceFilterType FilterType,double dMinElevation,double dMaxElevation) 
		{
			return this._i.ExtractContour(ViewType,FilterType,dMinElevation,dMaxElevation);
		}
	}
}
