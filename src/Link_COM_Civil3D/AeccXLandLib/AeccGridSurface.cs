namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccGridSurface _i;
		internal AeccGridSurface(object AeccGridSurface_object) 
		{
			this._i = AeccGridSurface_object as Autodesk.AECC.Interop.Land.IAeccGridSurface;
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
		public dynamic DEMFiles => this._i.DEMFiles;

		///<summary>
		///
		///</summary>
		public object OutputCells => this._i.OutputCells;
	}
}
