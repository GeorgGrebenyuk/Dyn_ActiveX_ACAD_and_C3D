namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLoftedSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLoftedSurface _i;
		internal AcadLoftedSurface(object AcadLoftedSurface_object) 
		{
			this._i = AcadLoftedSurface_object as Autodesk.AutoCAD.Interop.Common.AcadLoftedSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public int NumCrossSections => this._i.NumCrossSections;

		///<summary>
		///
		///</summary>
		public int NumGuidePaths => this._i.NumGuidePaths;

		///<summary>
		///
		///</summary>
		public object SurfaceNormals => this._i.SurfaceNormals;

		///<summary>
		///
		///</summary>
		public void Set_SurfaceNormals(Autodesk.AutoCAD.Interop.Common.AcLoftedSurfaceNormalType surfaceNormal) 
		{
			this._i.SurfaceNormals = surfaceNormal;
		}

		///<summary>
		///
		///</summary>
		public double StartDraftAngle => this._i.StartDraftAngle;

		///<summary>
		///
		///</summary>
		public void Set_StartDraftAngle(double StartDraftAngle) 
		{
			this._i.StartDraftAngle = StartDraftAngle;
		}

		///<summary>
		///
		///</summary>
		public double StartDraftMagnitude => this._i.StartDraftMagnitude;

		///<summary>
		///
		///</summary>
		public void Set_StartDraftMagnitude(double startDraftMag) 
		{
			this._i.StartDraftMagnitude = startDraftMag;
		}

		///<summary>
		///
		///</summary>
		public double EndDraftAngle => this._i.EndDraftAngle;

		///<summary>
		///
		///</summary>
		public void Set_EndDraftAngle(double EndDraftAngle) 
		{
			this._i.EndDraftAngle = EndDraftAngle;
		}

		///<summary>
		///
		///</summary>
		public double EndDraftMagnitude => this._i.EndDraftMagnitude;

		///<summary>
		///
		///</summary>
		public void Set_EndDraftMagnitude(double endDraftMag) 
		{
			this._i.EndDraftMagnitude = endDraftMag;
		}

		///<summary>
		///
		///</summary>
		public bool Closed => this._i.Closed;

		///<summary>
		///
		///</summary>
		public void Set_Closed(bool bClosed) 
		{
			this._i.Closed = bClosed;
		}

		///<summary>
		///
		///</summary>
		public double StartSmoothMagnitude => this._i.StartSmoothMagnitude;

		///<summary>
		///
		///</summary>
		public void Set_StartSmoothMagnitude(double startSmoothMag) 
		{
			this._i.StartSmoothMagnitude = startSmoothMag;
		}

		///<summary>
		///
		///</summary>
		public double EndSmoothMagnitude => this._i.EndSmoothMagnitude;

		///<summary>
		///
		///</summary>
		public void Set_EndSmoothMagnitude(double endSmoothMag) 
		{
			this._i.EndSmoothMagnitude = endSmoothMag;
		}

		///<summary>
		///
		///</summary>
		public int StartSmoothContinuity => this._i.StartSmoothContinuity;

		///<summary>
		///
		///</summary>
		public void Set_StartSmoothContinuity(int StartSmoothContinuity) 
		{
			this._i.StartSmoothContinuity = StartSmoothContinuity;
		}

		///<summary>
		///
		///</summary>
		public int EndSmoothContinuity => this._i.EndSmoothContinuity;

		///<summary>
		///
		///</summary>
		public void Set_EndSmoothContinuity(int EndSmoothContinuity) 
		{
			this._i.EndSmoothContinuity = EndSmoothContinuity;
		}

		///<summary>
		///
		///</summary>
		public bool Periodic => this._i.Periodic;

		///<summary>
		///
		///</summary>
		public void Set_Periodic(bool bPeriodic) 
		{
			this._i.Periodic = bPeriodic;
		}
	}
}
