﻿using System.Collections.Generic;
using System.Data.OleDb;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSection 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSection _i;
		internal AcadSection(object AcadSection_object) 
		{
			this._i = AcadSection_object as Autodesk.AutoCAD.Interop.Common.AcadSection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic State => this._i.State;

		///<summary>
		///
		///</summary>
		public void Set_State(Autodesk.AutoCAD.Interop.Common.AcSectionState pVal) 
		{
			this._i.State = pVal;
		}

		///<summary>
		///
		///</summary>
		public object ViewingDirection => this._i.ViewingDirection;

		///<summary>
		///
		///</summary>
		public void Set_ViewingDirection(object pVal) 
		{
			this._i.ViewingDirection = pVal;
		}

		///<summary>
		///
		///</summary>
		public object VerticalDirection => this._i.VerticalDirection;

		///<summary>
		///
		///</summary>
		public void Set_VerticalDirection(object pVal) 
		{
			this._i.VerticalDirection = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public bool LiveSectionEnabled => this._i.LiveSectionEnabled;

		///<summary>
		///
		///</summary>
		public void Set_LiveSectionEnabled(bool pVal) 
		{
			this._i.LiveSectionEnabled = pVal;
		}

		///<summary>
		///
		///</summary>
		public int IndicatorTransparency => this._i.IndicatorTransparency;

		///<summary>
		///
		///</summary>
		public void Set_IndicatorTransparency(int pVal) 
		{
			this._i.IndicatorTransparency = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor IndicatorFillColor => new AcadAcCmColor(this._i.IndicatorFillColor);

		///<summary>
		///
		///</summary>
		public void Set_IndicatorFillColor(dynamic pColor) 
		{
			this._i.IndicatorFillColor = pColor;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pVal) 
		{
			this._i.Elevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double TopHeight => this._i.TopHeight;

		///<summary>
		///
		///</summary>
		public void Set_TopHeight(double pVal) 
		{
			this._i.TopHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public double BottomHeight => this._i.BottomHeight;

		///<summary>
		///
		///</summary>
		public void Set_BottomHeight(double pVal) 
		{
			this._i.BottomHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public int NumVertices => this._i.NumVertices;

		///<summary>
		///
		///</summary>
		public object Vertices => this._i.Vertices;

		///<summary>
		///
		///</summary>
		public void Set_Vertices(object pVal) 
		{
			this._i.Vertices = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Coordinate(int Index) 
		{
			return this._i.Coordinate[Index];
		}

		///<summary>
		///
		///</summary>
		public void Set_Coordinate(int Index,object pVal) 
		{
            this._i.Coordinate[Index] = pVal;
		}

		///<summary>
		///
		///</summary>
		public void AddVertex(int nIndex,object val) 
		{
			this._i.AddVertex(nIndex,val);
		}

		///<summary>
		///
		///</summary>
		public void RemoveVertex(int nIndex) 
		{
			this._i.RemoveVertex(nIndex);
		}

		///<summary>
		///
		///</summary>
		public List<object> HitTest(object varPtHit)
        {
			bool pHit;
			int pSegmentIndex;
			object pPtOnSegment;
			Autodesk.AutoCAD.Interop.Common.AcSectionSubItem pSubItem;

            this._i.HitTest(varPtHit,out pHit,out pSegmentIndex,out pPtOnSegment,out pSubItem);
			return new List<object> { pHit, pSegmentIndex, pPtOnSegment, pSubItem };
		}

		///<summary>
		///
		///</summary>
		public void CreateJog(object varPt) 
		{
			this._i.CreateJog(varPt);
		}

		///<summary>
		///
		///</summary>
		public AcadSectionSettings Settings => new AcadSectionSettings(this._i.Settings);

		///<summary>
		///
		///</summary>
		public List<object> GenerateSectionGeometry(dynamic pEntity)
        {
			object pIntersectionBoundaryObjs;
			object pIntersectionFillObjs;
			object pBackgroudnObjs;
			object pForegroudObjs;
			object pCurveTangencyObjs;

            this._i.GenerateSectionGeometry(pEntity,out pIntersectionBoundaryObjs,out pIntersectionFillObjs,out pBackgroudnObjs,out pForegroudObjs,out pCurveTangencyObjs);
			return new List<object> { pIntersectionBoundaryObjs, pIntersectionFillObjs, pBackgroudnObjs, pForegroudObjs, pCurveTangencyObjs };
		}
	}
}