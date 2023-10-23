using Autodesk.AutoCAD.Interop.Common;
using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

    ///<summary>
    /// An object composed of an arrowhead attached to splines or straight line segments
    ///</summary>
    public class AcadLeader 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLeader _i;
		internal AcadLeader(object AcadLeader_object) 
		{
			this._i = AcadLeader_object as Autodesk.AutoCAD.Interop.Common.AcadLeader;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Try cast from AcadEntity
		/// </summary>
		/// <param name="AcadEntity"></param>
		/// <exception cref="System.Exception"></exception>
		public AcadLeader(AcadEntity AcadEntity)
		{
			this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadLeader;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Creates a leader line based on the provided coordinates or adds a new leader cluster to the MLeader object with Annotation object
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="PointsArray">Three points (gets only x/y coordinates)</param>
        /// <param name="Annotation">The ont AcadEntity (casted from AcadBlockReference, AcadMText, AcadTolerance) that should be attached to the leader. The value can also be NULL to not attach an object</param>
        /// <param name="Type"></param>
        public AcadLeader (AcadBlock AcadBlock, List<Point> PointsArray, 
			Autodesk.AutoCAD.Interop.Common.AcLeaderType Type, AcadEntity Annotation)
        {
            this._i = AcadBlock._i.AddLeader(Technical.PointsByDynPoints(PointsArray, false),
                Annotation._i, Type);
        }
        /// <summary>
        /// Creates a leader line based on the provided coordinates or adds a new leader cluster to the MLeader object without Annotation object
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="PointsArray">Three points (gets only x/y coordinates)</param>
        /// <param name="Type"></param>
        public AcadLeader(AcadBlock AcadBlock, List<Point> PointsArray,
            Autodesk.AutoCAD.Interop.Common.AcLeaderType Type)
        {
            this._i = AcadBlock._i.AddLeader(Technical.PointsByDynPoints(PointsArray, false),
                null, Type);
        }
        ///<summary>
        /// Get all cordinates in that object as array of Points
        ///</summary>
        public List<Point> Coordinates => Technical.PointsByArrayOfDoubleArray(this._i.Coordinates, true);

        ///<summary>
        /// Set coordinates to that objects from Dynamo's points array
        ///</summary>
        public void Set_Coordinates(List<Point> Coordinates)
        {
            this._i.Coordinates = Technical.PointsByDynPoints(Coordinates, true);
        }

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

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
        /// Get point by it's index from that object
        ///</summary>
        public Point Coordinate(int Index)
        {
            return Technical.PointByDoubleArray(this._i.Coordinate[Index]);
        }

        ///<summary>
        /// Set point by it's index to that object
        ///</summary>
        public void Set_Coordinate(int Index, Point pVal)
        {
            this._i.Coordinate[Index] = Technical.PointByDynPoint(pVal);
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
