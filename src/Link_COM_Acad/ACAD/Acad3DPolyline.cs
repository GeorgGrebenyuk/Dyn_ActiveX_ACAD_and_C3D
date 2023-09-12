namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class Acad3DPolyline 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcad3DPolyline _i;
		internal Acad3DPolyline(object Acad3DPolyline_object) 
		{
			this._i = Acad3DPolyline_object as Autodesk.AutoCAD.Interop.Common.IAcad3DPolyline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Coordinates => this._i.Coordinates;

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
		public void AppendVertex(object vertex) 
		{
			this._i.AppendVertex(vertex);
		}

		///<summary>
		///
		///</summary>
		public object Explode => this._i.Explode();

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
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(Autodesk.AutoCAD.Interop.Common.Ac3DPolylineType Type) 
		{
			this._i.Type = Type;
		}

		///<summary>
		///
		///</summary>
		public bool Closed => this._i.Closed;

		///<summary>
		///
		///</summary>
		public void Set_Closed(bool fClose) 
		{
			this._i.Closed = fClose;
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;
	}
}
