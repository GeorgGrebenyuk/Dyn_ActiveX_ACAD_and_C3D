namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceGridStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceGridStyle _i;
		internal AeccSurfaceGridStyle(object AeccSurfaceGridStyle_object) 
		{
			this._i = AeccSurfaceGridStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceGridStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool UsePrimaryGrid => this._i.UsePrimaryGrid;

		///<summary>
		///
		///</summary>
		public void Set_UsePrimaryGrid(bool pVal) 
		{
			this._i.UsePrimaryGrid = pVal;
		}

		///<summary>
		///
		///</summary>
		public double PrimaryGridInterval => this._i.PrimaryGridInterval;

		///<summary>
		///
		///</summary>
		public void Set_PrimaryGridInterval(double pVal) 
		{
			this._i.PrimaryGridInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public double PrimaryGridOrientation => this._i.PrimaryGridOrientation;

		///<summary>
		///
		///</summary>
		public void Set_PrimaryGridOrientation(double pVal) 
		{
			this._i.PrimaryGridOrientation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseSecondaryGrid => this._i.UseSecondaryGrid;

		///<summary>
		///
		///</summary>
		public void Set_UseSecondaryGrid(bool pVal) 
		{
			this._i.UseSecondaryGrid = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SecondaryGridInterval => this._i.SecondaryGridInterval;

		///<summary>
		///
		///</summary>
		public void Set_SecondaryGridInterval(double pVal) 
		{
			this._i.SecondaryGridInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SecondaryGridOrientation => this._i.SecondaryGridOrientation;

		///<summary>
		///
		///</summary>
		public void Set_SecondaryGridOrientation(double pVal) 
		{
			this._i.SecondaryGridOrientation = pVal;
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
