namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLandFeatureLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccLandFeatureLine _i;
		internal AeccLandFeatureLine(object AeccLandFeatureLine_object) 
		{
			this._i = AeccLandFeatureLine_object as Autodesk.AECC.Interop.Land.IAeccLandFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PointsCount => this._i.PointsCount;

		///<summary>
		///
		///</summary>
		public dynamic PIPointsCount => this._i.PIPointsCount;

		///<summary>
		///
		///</summary>
		public dynamic ElevationPointsCount => this._i.ElevationPointsCount;

		///<summary>
		///
		///</summary>
		public double Length2D => this._i.Length2D;

		///<summary>
		///
		///</summary>
		public double Length3D => this._i.Length3D;

		///<summary>
		///
		///</summary>
		public double MiniElevation => this._i.MiniElevation;

		///<summary>
		///
		///</summary>
		public double MaxElevation => this._i.MaxElevation;

		///<summary>
		///
		///</summary>
		public double MiniGrade => this._i.MiniGrade;

		///<summary>
		///
		///</summary>
		public double MaxGrade => this._i.MaxGrade;

		///<summary>
		///
		///</summary>
		public object GetPoints(Autodesk.AECC.Interop.Land.AeccLandFeatureLinePointType pointType) 
		{
			return this._i.GetPoints(pointType);
		}

		///<summary>
		///
		///</summary>
		public void SetPointElevation(object varPoint) 
		{
			this._i.SetPointElevation(varPoint);
		}

		///<summary>
		///
		///</summary>
		public void SetPointsElevation(object varPoints) 
		{
			this._i.SetPointsElevation(varPoints);
		}

		///<summary>
		///
		///</summary>
		public void SetElevationsFromOffsetSource(dynamic pOffsetTarget) 
		{
			this._i.SetElevationsFromOffsetSource(pOffsetTarget);
		}

		///<summary>
		///
		///</summary>
		public void InsertFeaturePoint(object varPoint,Autodesk.AECC.Interop.Land.AeccLandFeatureLinePointType pointType) 
		{
			this._i.InsertFeaturePoint(varPoint,pointType);
		}

		///<summary>
		///
		///</summary>
		public void InsertFeaturePoints(object varPoints,Autodesk.AECC.Interop.Land.AeccLandFeatureLinePointType pointType) 
		{
			this._i.InsertFeaturePoints(varPoints,pointType);
		}

		///<summary>
		///
		///</summary>
		public void DeleteFeaturePoint(object varPoint) 
		{
			this._i.DeleteFeaturePoint(varPoint);
		}

		///<summary>
		///
		///</summary>
		public double Get2dDistanceAtPoint(object varPoint) 
		{
			return this._i.Get2dDistanceAtPoint(varPoint);
		}

		///<summary>
		///
		///</summary>
		public double Get2dDistanceBetweenPoints(object varFromPoint,object varToPoint) 
		{
			return this._i.Get2dDistanceBetweenPoints(varFromPoint,varToPoint);
		}

		///<summary>
		///
		///</summary>
		public void GetGradesAtPoint(object varPoint,out double pGradeIn,out double pGradeOut) 
		{
			this._i.GetGradesAtPoint(varPoint,out pGradeIn,out pGradeOut);
		}

		///<summary>
		///
		///</summary>
		public object GetSurfaceIntersectPoints(dynamic pSurface) 
		{
			return this._i.GetSurfaceIntersectPoints(pSurface);
		}

		///<summary>
		///
		///</summary>
		public double GetBulgeAtPoint(object varPoint) 
		{
			return this._i.GetBulgeAtPoint(varPoint);
		}

		///<summary>
		///
		///</summary>
		public void SetBulgeAtPoint(object varPoint,double Bulge) 
		{
			this._i.SetBulgeAtPoint(varPoint,Bulge);
		}

		///<summary>
		///
		///</summary>
		public double GetDeflectionAngleAtPoint(object varPoint) 
		{
			return this._i.GetDeflectionAngleAtPoint(varPoint);
		}

		///<summary>
		///
		///</summary>
		public void RaiseFeatureLine(double Elevation) 
		{
			this._i.RaiseFeatureLine(Elevation);
		}

		///<summary>
		///
		///</summary>
		public bool IsGradeBreak(object varPoint) 
		{
			return this._i.IsGradeBreak(varPoint);
		}

		///<summary>
		///
		///</summary>
		public bool IsEditable => this._i.IsEditable;
	}
}
