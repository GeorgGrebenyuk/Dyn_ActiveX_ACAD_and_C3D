using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class Acad3DFace 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcad3DFace _i;
		internal Acad3DFace(object Acad3DFace_object) 
		{
			this._i = Acad3DFace_object as Autodesk.AutoCAD.Interop.Common.IAcad3DFace;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public Acad3DFace(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.Acad3DFace;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///Create new 3D face
        ///</summary>
        public Acad3DFace(AcadBlock AcadBlock, Point Point1, Point Point2, Point Point3, Point Point4)
        {
            this._i =  AcadBlock._i.Add3DFace(
				Technical.PointByDynPoint(Point1), 
				Technical.PointByDynPoint(Point2), 
				Technical.PointByDynPoint(Point3), 
				Technical.PointByDynPoint(Point4));
        }

        ///<summary>
        ///
        ///</summary>
        public object Coordinates => this._i.Coordinates;

		///<summary>
		///
		///</summary>
		public void Set_Coordinates(object corners) 
		{
			this._i.Coordinates = corners;
		}

		///<summary>
		///
		///</summary>
		public bool VisibilityEdge1 => this._i.VisibilityEdge1;

		///<summary>
		///
		///</summary>
		public void Set_VisibilityEdge1(bool visibility) 
		{
			this._i.VisibilityEdge1 = visibility;
		}

		///<summary>
		///
		///</summary>
		public bool VisibilityEdge2 => this._i.VisibilityEdge2;

		///<summary>
		///
		///</summary>
		public void Set_VisibilityEdge2(bool visibility) 
		{
			this._i.VisibilityEdge2 = visibility;
		}

		///<summary>
		///
		///</summary>
		public bool VisibilityEdge3 => this._i.VisibilityEdge3;

		///<summary>
		///
		///</summary>
		public void Set_VisibilityEdge3(bool visibility) 
		{
			this._i.VisibilityEdge3 = visibility;
		}

		///<summary>
		///
		///</summary>
		public bool VisibilityEdge4 => this._i.VisibilityEdge4;

		///<summary>
		///
		///</summary>
		public void Set_VisibilityEdge4(bool visibility) 
		{
			this._i.VisibilityEdge4 = visibility;
		}

		///<summary>
		///
		///</summary>
		public bool GetInvisibleEdge(int Index) 
		{
			return this._i.GetInvisibleEdge(Index);
		}

		///<summary>
		///
		///</summary>
		public void SetInvisibleEdge(int Index,bool State) 
		{
			this._i.SetInvisibleEdge(Index,State);
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
	}
}
