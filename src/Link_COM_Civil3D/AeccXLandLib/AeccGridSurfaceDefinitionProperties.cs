namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridSurfaceDefinitionProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccGridSurfaceDefinitionProperties _i;
		internal AeccGridSurfaceDefinitionProperties(object AeccGridSurfaceDefinitionProperties_object) 
		{
			this._i = AeccGridSurfaceDefinitionProperties_object as Autodesk.AECC.Interop.Land.IAeccGridSurfaceDefinitionProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool UseDEMFiles => this._i.UseDEMFiles;

		///<summary>
		///
		///</summary>
		public void Set_UseDEMFiles(bool pVal) 
		{
			this._i.UseDEMFiles = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseRaiseLowerSurface => this._i.UseRaiseLowerSurface;

		///<summary>
		///
		///</summary>
		public void Set_UseRaiseLowerSurface(bool pVal) 
		{
			this._i.UseRaiseLowerSurface = pVal;
		}
	}
}
