namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBoundaryStyle 
	{
		public AeccXLandLib.IAeccSurfaceBoundaryStyle _i;
		internal AeccSurfaceBoundaryStyle(object AeccSurfaceBoundaryStyle_object) 
		{
			this._i = AeccSurfaceBoundaryStyle_object as AeccXLandLib.IAeccSurfaceBoundaryStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool DisplayExteriorBoundaries => this._i.DisplayExteriorBoundaries;

		///<summary>
		///
		///</summary>
		public void Set_DisplayExteriorBoundaries(bool pVal) 
		{
			this._i.DisplayExteriorBoundaries = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool DisplayInteriorBoundaries => this._i.DisplayInteriorBoundaries;

		///<summary>
		///
		///</summary>
		public void Set_DisplayInteriorBoundaries(bool pVal) 
		{
			this._i.DisplayInteriorBoundaries = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDatum => this._i.UseDatum;

		///<summary>
		///
		///</summary>
		public void Set_UseDatum(bool pVal) 
		{
			this._i.UseDatum = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ProjectGridToDatum => this._i.ProjectGridToDatum;

		///<summary>
		///
		///</summary>
		public void Set_ProjectGridToDatum(bool pVal) 
		{
			this._i.ProjectGridToDatum = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DatumElevation => this._i.DatumElevation;

		///<summary>
		///
		///</summary>
		public void Set_DatumElevation(double pVal) 
		{
			this._i.DatumElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d => this._i.DisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel => this._i.DisplayStyleModel;
	}
}
