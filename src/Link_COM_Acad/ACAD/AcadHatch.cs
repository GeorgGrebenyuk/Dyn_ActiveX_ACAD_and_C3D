
using Autodesk.AutoCAD.Interop.Common;
using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadHatch 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadHatch _i;
		internal AcadHatch(object AcadHatch_object) 
		{
			this._i = AcadHatch_object as Autodesk.AutoCAD.Interop.Common.AcadHatch;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadHatch(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadHatch;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
		///<summary>
		/// Create new hatch object
		///</summary>
		public AcadHatch (dynamic AcadBlock, int PatternType, string PatternName, 
			bool Associativity, AcHatchObjectType HatchObjectType)
		{
			this._i = AcadBlock._i.AddHatch(PatternType, PatternName, Associativity, HatchObjectType);
		}

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
        }

        ///<summary>
        ///
        ///</summary>
        public int NumberOfLoops => this._i.NumberOfLoops;

		///<summary>
		///
		///</summary>
		public object PatternType => this._i.PatternType;

		///<summary>
		///
		///</summary>
		public string PatternName => this._i.PatternName;

		///<summary>
		///
		///</summary>
		public double PatternAngle => this._i.PatternAngle;

		///<summary>
		///
		///</summary>
		public void Set_PatternAngle(double PatternAngle) 
		{
			this._i.PatternAngle = PatternAngle;
		}

		///<summary>
		///
		///</summary>
		public double PatternScale => this._i.PatternScale;

		///<summary>
		///
		///</summary>
		public void Set_PatternScale(double PatternScale) 
		{
			this._i.PatternScale = PatternScale;
		}

		///<summary>
		///
		///</summary>
		public double PatternSpace => this._i.PatternSpace;

		///<summary>
		///
		///</summary>
		public void Set_PatternSpace(double PatternSpace) 
		{
			this._i.PatternSpace = PatternSpace;
		}

		///<summary>
		///
		///</summary>
		public object ISOPenWidth => this._i.ISOPenWidth;

		///<summary>
		///
		///</summary>
		public void Set_ISOPenWidth(Autodesk.AutoCAD.Interop.Common.AcISOPenWidth penWidth) 
		{
			this._i.ISOPenWidth = penWidth;
		}

		///<summary>
		///
		///</summary>
		public bool PatternDouble => this._i.PatternDouble;

		///<summary>
		///
		///</summary>
		public void Set_PatternDouble(bool bDouble) 
		{
			this._i.PatternDouble = bDouble;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double Elevation) 
		{
			this._i.Elevation = Elevation;
		}

		///<summary>
		///
		///</summary>
		public bool AssociativeHatch => this._i.AssociativeHatch;

		///<summary>
		///
		///</summary>
		public void Set_AssociativeHatch(bool fAssoc) 
		{
			this._i.AssociativeHatch = fAssoc;
		}

		///<summary>
		///
		///</summary>
		public object HatchStyle => this._i.HatchStyle;

		///<summary>
		///
		///</summary>
		public void Set_HatchStyle(Autodesk.AutoCAD.Interop.Common.AcHatchStyle HatchStyle) 
		{
			this._i.HatchStyle = HatchStyle;
		}

		///<summary>
		///
		///</summary>
		public void SetPattern(int PatternType,string PatternName) 
		{
			this._i.SetPattern(PatternType,PatternName);
		}

		///<summary>
		///
		///</summary>
		public void AppendOuterLoop(List<AcadEntity> ObjectArray) 
		{
			this._i.AppendOuterLoop(ObjectArray.Select(e=>e._i).ToArray());
		}

		///<summary>
		///
		///</summary>
		public void AppendInnerLoop(List<AcadEntity> ObjectArray) 
		{
			this._i.AppendInnerLoop(ObjectArray.Select(e => e._i).ToArray());
		}

		///<summary>
		///
		///</summary>
		public void InsertLoopAt(int Index,Autodesk.AutoCAD.Interop.Common.AcLoopType LoopType, List<AcadEntity> ObjectArray) 
		{
			this._i.InsertLoopAt(Index,LoopType, ObjectArray.Select(e => e._i).ToArray());
		}

		///<summary>
		///
		///</summary>
		public List<AcadEntity> GetLoopAt(int Index) 
		{
			object out_info;
			this._i.GetLoopAt(Index,out out_info);
            return ((Array)out_info).Cast<object>().Select(e=> new AcadEntity(e)).ToList();
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
		public AcadAcCmColor GradientColor1 => new AcadAcCmColor (this._i.GradientColor1);

		///<summary>
		///
		///</summary>
		public void Set_GradientColor1(AcadAcCmColor pColor) 
		{
			this._i.GradientColor1 = pColor._i;
		}

        ///<summary>
        ///
        ///</summary>
        public AcadAcCmColor GradientColor2 => new AcadAcCmColor(this._i.GradientColor2);

        ///<summary>
        ///
        ///</summary>
		public void Set_GradientColor2(AcadAcCmColor pColor)
        {
            this._i.GradientColor2 = pColor._i;
        }

        ///<summary>
        ///
        ///</summary>
        public double GradientAngle => this._i.GradientAngle;

		///<summary>
		///
		///</summary>
		public void Set_GradientAngle(double GradientAngle) 
		{
			this._i.GradientAngle = GradientAngle;
		}

		///<summary>
		///
		///</summary>
		public bool GradientCentered => this._i.GradientCentered;

		///<summary>
		///
		///</summary>
		public void Set_GradientCentered(bool fCentered) 
		{
			this._i.GradientCentered = fCentered;
		}

		///<summary>
		///
		///</summary>
		public string GradientName => this._i.GradientName;

		///<summary>
		///
		///</summary>
		public void Set_GradientName(string bstrName) 
		{
			this._i.GradientName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public object HatchObjectType => this._i.HatchObjectType;

		///<summary>
		///
		///</summary>
		public void Set_HatchObjectType(Autodesk.AutoCAD.Interop.Common.AcHatchObjectType hatchType) 
		{
			this._i.HatchObjectType = hatchType;
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public Point Origin => Technical.PointByDoubleArray(this._i.Origin);

		///<summary>
		///
		///</summary>
		public void Set_Origin(Point Origin) 
		{
			this._i.Origin = Technical.PointByDynPoint(Origin);
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor BackgroundColor => new AcadAcCmColor(this._i.BackgroundColor);

		///<summary>
		///
		///</summary>
		public void Set_BackgroundColor(AcadAcCmColor pColor) 
		{
			this._i.BackgroundColor = pColor._i;
		}
	}
}
