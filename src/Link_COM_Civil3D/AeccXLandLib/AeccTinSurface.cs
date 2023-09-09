namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccTinSurface _i;
		internal AeccTinSurface(object AeccTinSurface_object) 
		{
			this._i = AeccTinSurface_object as Autodesk.AECC.Interop.Land.IAeccTinSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Statistics => this._i.Statistics;

		///<summary>
		///
		///</summary>
		public dynamic DefinitionProperties => this._i.DefinitionProperties;

		///<summary>
		///
		///</summary>
		public dynamic Breaklines => this._i.Breaklines;

		///<summary>
		///
		///</summary>
		public dynamic Contours => this._i.Contours;

		///<summary>
		///
		///</summary>
		public dynamic DEMFiles => this._i.DEMFiles;

		///<summary>
		///
		///</summary>
		public dynamic PointFiles => this._i.PointFiles;

		///<summary>
		///
		///</summary>
		public dynamic PointGroups => this._i.PointGroups;

		///<summary>
		///
		///</summary>
		public object OutputTriangles => this._i.OutputTriangles;

		///<summary>
		///
		///</summary>
		public void PasteSurface(dynamic pSrcSurface) 
		{
			this._i.PasteSurface(pSrcSurface);
		}

		///<summary>
		///
		///</summary>
		public void AddPointMultiple(object varPoints) 
		{
			this._i.AddPointMultiple(varPoints);
		}
	}
}
