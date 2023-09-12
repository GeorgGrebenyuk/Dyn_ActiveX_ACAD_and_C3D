﻿using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLeader 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadLeader _i;
		internal AcadLeader(object AcadLeader_object) 
		{
			this._i = AcadLeader_object as Autodesk.AutoCAD.Interop.Common.IAcadLeader;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Try cast from AcadEntity
		/// </summary>
		/// <param name="AcadEntity"></param>
		/// <exception cref="System.Exception"></exception>
		public AcadLeader(AcadEntity AcadEntity)
		{
			this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.IAcadLeader;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Create new Leader
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="PointsArray"></param>
		/// <param name="Annotation"></param>
		/// <param name="Type"></param>
        public AcadLeader (AcadBlock AcadBlock, List<Point> PointsArray, AcadEntity Annotation, Autodesk.AutoCAD.Interop.Common.AcLeaderType Type)
        {
            this._i = AcadBlock._i.AddLeader(PointsArray.Select(a => Technical.PointByDynPoint(a)).ToArray(), Annotation._i, Type);
        }
        ///<summary>
        ///
        ///</summary>
        public dynamic Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object Coordinates) 
		{
			this._i.Coordinates = Coordinates;
		}

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public void Set_StyleName(string bstrName) 
		{
			this._i.StyleName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(Autodesk.AutoCAD.Interop.Common.AcLeaderType Type) 
		{
			this._i.Type = Type;
		}

		///<summary>
		///
		///</summary>
		public void Evaluate() 
		{
			this._i.Evaluate();
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
		public dynamic Annotation => this._i.Annotation;

		///<summary>
		///
		///</summary>
		public void Set_Annotation(dynamic pVal) 
		{
			this._i.Annotation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ArrowheadSize => this._i.ArrowheadSize;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadSize(double size) 
		{
			this._i.ArrowheadSize = size;
		}

		///<summary>
		///
		///</summary>
		public dynamic ArrowheadType => this._i.ArrowheadType;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadType(Autodesk.AutoCAD.Interop.Common.AcDimArrowheadType Type) 
		{
			this._i.ArrowheadType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic DimensionLineColor => this._i.DimensionLineColor;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLineColor(dynamic Type) 
		{
			this._i.DimensionLineColor = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic DimensionLineWeight => this._i.DimensionLineWeight;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLineWeight(dynamic weight) 
		{
			this._i.DimensionLineWeight = weight;
		}

		///<summary>
		///
		///</summary>
		public dynamic ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(dynamic factor) 
		{
			this._i.ScaleFactor = factor;
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalTextPosition => this._i.VerticalTextPosition;

		///<summary>
		///
		///</summary>
		public void Set_VerticalTextPosition(Autodesk.AutoCAD.Interop.Common.AcDimVerticalJustification Type) 
		{
			this._i.VerticalTextPosition = Type;
		}

		///<summary>
		///
		///</summary>
		public double TextGap => this._i.TextGap;

		///<summary>
		///
		///</summary>
		public void Set_TextGap(double Offset) 
		{
			this._i.TextGap = Offset;
		}

		///<summary>
		///
		///</summary>
		public string ArrowheadBlock => this._i.ArrowheadBlock;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadBlock(string BlockName) 
		{
			this._i.ArrowheadBlock = BlockName;
		}
	}
}
