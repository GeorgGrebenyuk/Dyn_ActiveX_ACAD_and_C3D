using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSpline 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSpline _i;
		internal AcadSpline(object AcadSpline_object) 
		{
			this._i = AcadSpline_object as Autodesk.AutoCAD.Interop.Common.AcadSpline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadSpline(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadSpline;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        ///
        ///</summary>
        public AcadSpline (AcadBlock AcadBlock, List<Point> PointsArray, Vector StartTangent, Vector EndTangent)
        {
            this._i = AcadBlock._i.AddSpline(
				PointsArray.Select(p => Technical.PointByDynPoint(p)).ToArray(), 
				Technical.VectorByDynVector(StartTangent), Technical.VectorByDynVector(EndTangent));
        }

        ///<summary>
        ///
        ///</summary>
        public int NumberOfControlPoints => this._i.NumberOfControlPoints;

		///<summary>
		///
		///</summary>
		public object ControlPoints => this._i.ControlPoints;

		///<summary>
		///
		///</summary>
		public void Set_ControlPoints(object controlPoint) 
		{
			this._i.ControlPoints = controlPoint;
		}

		///<summary>
		///
		///</summary>
		public int NumberOfFitPoints => this._i.NumberOfFitPoints;

		///<summary>
		///
		///</summary>
		public object FitPoints => this._i.FitPoints;

		///<summary>
		///
		///</summary>
		public void Set_FitPoints(object fitPoint) 
		{
			this._i.FitPoints = fitPoint;
		}

		///<summary>
		///
		///</summary>
		public int Degree => this._i.Degree;

		///<summary>
		///
		///</summary>
		public bool Closed => this._i.Closed;

		///<summary>
		///
		///</summary>
		public bool IsPlanar => this._i.IsPlanar;

		///<summary>
		///
		///</summary>
		public bool IsRational => this._i.IsRational;

		///<summary>
		///
		///</summary>
		public bool IsPeriodic => this._i.IsPeriodic;

		///<summary>
		///
		///</summary>
		public object StartTangent => this._i.StartTangent;

		///<summary>
		///
		///</summary>
		public void Set_StartTangent(object StartTangent) 
		{
			this._i.StartTangent = StartTangent;
		}

		///<summary>
		///
		///</summary>
		public object EndTangent => this._i.EndTangent;

		///<summary>
		///
		///</summary>
		public void Set_EndTangent(object EndTangent) 
		{
			this._i.EndTangent = EndTangent;
		}

		///<summary>
		///
		///</summary>
		public double FitTolerance => this._i.FitTolerance;

		///<summary>
		///
		///</summary>
		public void Set_FitTolerance(double fitTol) 
		{
			this._i.FitTolerance = fitTol;
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public void SetControlPoint(int Index,object controlPoint) 
		{
			this._i.SetControlPoint(Index,controlPoint);
		}

		///<summary>
		///
		///</summary>
		public object GetControlPoint(int Index) 
		{
			return this._i.GetControlPoint(Index);
		}

		///<summary>
		///
		///</summary>
		public void SetFitPoint(int Index,object fitPoint) 
		{
			this._i.SetFitPoint(Index,fitPoint);
		}

		///<summary>
		///
		///</summary>
		public object GetFitPoint(int Index) 
		{
			return this._i.GetFitPoint(Index);
		}

		///<summary>
		///
		///</summary>
		public void SetWeight(int Index,double weight) 
		{
			this._i.SetWeight(Index,weight);
		}

		///<summary>
		///
		///</summary>
		public double GetWeight(int Index) 
		{
			return this._i.GetWeight(Index);
		}

		///<summary>
		///
		///</summary>
		public void AddFitPoint(int Index,object fitPoint) 
		{
			this._i.AddFitPoint(Index,fitPoint);
		}

		///<summary>
		///
		///</summary>
		public void DeleteFitPoint(int Index) 
		{
			this._i.DeleteFitPoint(Index);
		}

		///<summary>
		///
		///</summary>
		public void ElevateOrder(int Order) 
		{
			this._i.ElevateOrder(Order);
		}

		///<summary>
		///
		///</summary>
		public object Offset(double Distance) 
		{
			return this._i.Offset(Distance);
		}

		///<summary>
		///
		///</summary>
		public void PurgeFitData() 
		{
			this._i.PurgeFitData();
		}

		///<summary>
		///
		///</summary>
		public void Reverse() 
		{
			this._i.Reverse();
		}

		///<summary>
		///
		///</summary>
		public object Knots => this._i.Knots;

		///<summary>
		///
		///</summary>
		public void Set_Knots(object KnotValues) 
		{
			this._i.Knots = KnotValues;
		}

		///<summary>
		///
		///</summary>
		public object Weights => this._i.Weights;

		///<summary>
		///
		///</summary>
		public void Set_Weights(object WeightValues) 
		{
			this._i.Weights = WeightValues;
		}

		///<summary>
		///
		///</summary>
		public dynamic KnotParameterization => this._i.KnotParameterization;

		///<summary>
		///
		///</summary>
		public void Set_KnotParameterization(Autodesk.AutoCAD.Interop.Common.AcSplineKnotParameterizationType knotParamVal) 
		{
			this._i.KnotParameterization = knotParamVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SplineFrame => this._i.SplineFrame;

		///<summary>
		///
		///</summary>
		public void Set_SplineFrame(Autodesk.AutoCAD.Interop.Common.AcSplineFrameType show) 
		{
			this._i.SplineFrame = show;
		}

		///<summary>
		///
		///</summary>
		public dynamic SplineMethod => this._i.SplineMethod;

		///<summary>
		///
		///</summary>
		public void Set_SplineMethod(Autodesk.AutoCAD.Interop.Common.AcSplineMethodType method) 
		{
			this._i.SplineMethod = method;
		}

		///<summary>
		///
		///</summary>
		public void Set_Degree2(dynamic Degree) 
		{
			this._i.Degree2 = Degree;
		}

		///<summary>
		///
		///</summary>
		public dynamic Degree2 => this._i.Degree2;

		///<summary>
		///
		///</summary>
		public void Set_Closed2(bool fClose) 
		{
			this._i.Closed2 = fClose;
		}

		///<summary>
		///
		///</summary>
		public bool Closed2 => this._i.Closed2;
	}
}
