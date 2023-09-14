﻿using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadTrace 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadTrace _i;
		internal AcadTrace(object AcadTrace_object) 
		{
			this._i = AcadTrace_object as Autodesk.AutoCAD.Interop.Common.AcadTrace;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
        ///
        ///</summary>
        public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public double Thickness => this._i.Thickness;

		///<summary>
		///
		///</summary>
		public void Set_Thickness(double Thickness) 
		{
			this._i.Thickness = Thickness;
		}

        ///<summary>
        /// Get point by it's index from that object
        ///</summary>
        public Point Coordinate(int Index)
        {
            return Technical.PointByDynPoint(this._i.Coordinate[Index]);
        }

        ///<summary>
        ///
        ///</summary>
        public void Set_Coordinate(int Index,object pVal) 
		{
            this._i.Coordinate[Index] = pVal;
		}
	}
}