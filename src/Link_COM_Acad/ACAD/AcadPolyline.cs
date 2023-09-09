﻿namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPolyline 
	{
		public AXDBLib.IAcadPolyline _i;
		internal AcadPolyline(object AcadPolyline_object) 
		{
			this._i = AcadPolyline_object as AXDBLib.IAcadPolyline;
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
		///
		///</summary>
		public void AppendVertex(object vertex) 
		{
			this._i.AppendVertex(vertex);
		}

		///<summary>
		///
		///</summary>
		public object Explode => this._i.Explode;

		///<summary>
		///
		///</summary>
		public double GetBulge(int Index) 
		{
			return this._i.GetBulge(Index);
		}

		///<summary>
		///
		///</summary>
		public void SetBulge(int Index,double bulge) 
		{
			this._i.SetBulge(Index,bulge);
		}

		///<summary>
		///
		///</summary>
		public void GetWidth(int Index,out double StartWidth) 
		{
			this._i.GetWidth(Index,out StartWidth);
		}

		///<summary>
		///
		///</summary>
		public void SetWidth(int Index,double StartWidth) 
		{
			this._i.SetWidth(Index,StartWidth);
		}

		///<summary>
		///
		///</summary>
		public double ConstantWidth => this._i.ConstantWidth;

		///<summary>
		///
		///</summary>
		public void Set_ConstantWidth(double Width) 
		{
			this._i.ConstantWidth = Width;
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
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(AXDBLib.AcPolylineType Type) 
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
		public bool LinetypeGeneration => this._i.LinetypeGeneration;

		///<summary>
		///
		///</summary>
		public void Set_LinetypeGeneration(bool bLinetypeGen) 
		{
			this._i.LinetypeGeneration = bLinetypeGen;
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public object Coordinate(int Index) 
		{
			return this._i.Coordinate(Index);
		}

		///<summary>
		///
		///</summary>
		public void Set_Coordinate(int Index,object pVal) 
		{
			this._i.Coordinate = Index,pVal;
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;
	}
}