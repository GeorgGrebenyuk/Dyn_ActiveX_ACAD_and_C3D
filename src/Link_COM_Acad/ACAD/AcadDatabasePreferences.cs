namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDatabasePreferences 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDatabasePreferences _i;
		internal AcadDatabasePreferences(object AcadDatabasePreferences_object) 
		{
			this._i = AcadDatabasePreferences_object as Autodesk.AutoCAD.Interop.Common.AcadDatabasePreferences;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Get preferences from AcadDatabase
        /// </summary>
        /// <param name="acadDatabase"></param>

        public AcadDatabasePreferences(AcadDatabase acadDatabase)
		{
			this._i = acadDatabase._i.Preferences;

        }

        ///<summary>
        ///
        ///</summary>
        public bool SolidFill => this._i.SolidFill;

		///<summary>
		///
		///</summary>
		public void Set_SolidFill(bool Fill) 
		{
			this._i.SolidFill = Fill;
		}

		///<summary>
		///
		///</summary>
		public bool XRefEdit => this._i.XRefEdit;

		///<summary>
		///
		///</summary>
		public void Set_XRefEdit(bool Edit) 
		{
			this._i.XRefEdit = Edit;
		}

		///<summary>
		///
		///</summary>
		public bool XRefLayerVisibility => this._i.XRefLayerVisibility;

		///<summary>
		///
		///</summary>
		public void Set_XRefLayerVisibility(bool XRefLayerVis) 
		{
			this._i.XRefLayerVisibility = XRefLayerVis;
		}

		///<summary>
		///
		///</summary>
		public bool OLELaunch => this._i.OLELaunch;

		///<summary>
		///
		///</summary>
		public void Set_OLELaunch(bool Launch) 
		{
			this._i.OLELaunch = Launch;
		}

		///<summary>
		///
		///</summary>
		public bool AllowLongSymbolNames => this._i.AllowLongSymbolNames;

		///<summary>
		///
		///</summary>
		public void Set_AllowLongSymbolNames(bool LongNames) 
		{
			this._i.AllowLongSymbolNames = LongNames;
		}

		///<summary>
		///
		///</summary>
		public bool ObjectSortBySelection => this._i.ObjectSortBySelection;

		///<summary>
		///
		///</summary>
		public void Set_ObjectSortBySelection(bool Sort) 
		{
			this._i.ObjectSortBySelection = Sort;
		}

		///<summary>
		///
		///</summary>
		public bool ObjectSortBySnap => this._i.ObjectSortBySnap;

		///<summary>
		///
		///</summary>
		public void Set_ObjectSortBySnap(bool Sort) 
		{
			this._i.ObjectSortBySnap = Sort;
		}

		///<summary>
		///
		///</summary>
		public bool ObjectSortByRedraws => this._i.ObjectSortByRedraws;

		///<summary>
		///
		///</summary>
		public void Set_ObjectSortByRedraws(bool Sort) 
		{
			this._i.ObjectSortByRedraws = Sort;
		}

		///<summary>
		///
		///</summary>
		public bool ObjectSortByRegens => this._i.ObjectSortByRegens;

		///<summary>
		///
		///</summary>
		public void Set_ObjectSortByRegens(bool Sort) 
		{
			this._i.ObjectSortByRegens = Sort;
		}

		///<summary>
		///
		///</summary>
		public bool ObjectSortByPlotting => this._i.ObjectSortByPlotting;

		///<summary>
		///
		///</summary>
		public void Set_ObjectSortByPlotting(bool Sort) 
		{
			this._i.ObjectSortByPlotting = Sort;
		}

		///<summary>
		///
		///</summary>
		public bool ObjectSortByPSOutput => this._i.ObjectSortByPSOutput;

		///<summary>
		///
		///</summary>
		public void Set_ObjectSortByPSOutput(bool Sort) 
		{
			this._i.ObjectSortByPSOutput = Sort;
		}

		///<summary>
		///
		///</summary>
		public void Set_ContourLinesPerSurface(dynamic Path) 
		{
			this._i.ContourLinesPerSurface = Path;
		}

		///<summary>
		///
		///</summary>
		public dynamic ContourLinesPerSurface => this._i.ContourLinesPerSurface;

		///<summary>
		///
		///</summary>
		public void Set_DisplaySilhouette(bool Path) 
		{
			this._i.DisplaySilhouette = Path;
		}

		///<summary>
		///
		///</summary>
		public bool DisplaySilhouette => this._i.DisplaySilhouette;

		///<summary>
		///
		///</summary>
		public void Set_MaxActiveViewports(dynamic Path) 
		{
			this._i.MaxActiveViewports = Path;
		}

		///<summary>
		///
		///</summary>
		public dynamic MaxActiveViewports => this._i.MaxActiveViewports;

		///<summary>
		///
		///</summary>
		public void Set_RenderSmoothness(double Path) 
		{
			this._i.RenderSmoothness = Path;
		}

		///<summary>
		///
		///</summary>
		public double RenderSmoothness => this._i.RenderSmoothness;

		///<summary>
		///
		///</summary>
		public void Set_SegmentPerPolyline(dynamic Path) 
		{
			this._i.SegmentPerPolyline = Path;
		}

		///<summary>
		///
		///</summary>
		public dynamic SegmentPerPolyline => this._i.SegmentPerPolyline;

		///<summary>
		///
		///</summary>
		public void Set_TextFrameDisplay(bool Path) 
		{
			this._i.TextFrameDisplay = Path;
		}

		///<summary>
		///
		///</summary>
		public bool TextFrameDisplay => this._i.TextFrameDisplay;

		///<summary>
		///
		///</summary>
		public void Set_Lineweight(Autodesk.AutoCAD.Interop.Common.AcLineWeight Path) 
		{
			this._i.Lineweight = Path;
		}

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public void Set_LineWeightDisplay(bool Path) 
		{
			this._i.LineWeightDisplay = Path;
		}

		///<summary>
		///
		///</summary>
		public bool LineWeightDisplay => this._i.LineWeightDisplay;
	}
}
