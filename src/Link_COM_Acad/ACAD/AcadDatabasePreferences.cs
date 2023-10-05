namespace DynAXDBLib 
{

    ///<summary>
    /// An object that specifies the settings for the current AutoCAD drawing
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
        ///Specifies if traces, solids, all hatches (including solid-fill), and wide polylines are filled in
        ///</summary>
        public bool SolidFill => this._i.SolidFill;

        ///<summary>
        ///Specifies if traces, solids, all hatches (including solid-fill), and wide polylines are filled in
        ///</summary>
        public void Set_SolidFill(bool SolidFill) 
		{
			this._i.SolidFill = SolidFill;
		}

        ///<summary>
        ///Determines if the current drawing can be edited in place when being referenced by another user
        ///</summary>
        public bool XRefEdit => this._i.XRefEdit;

        ///<summary>
        ///Determines if the current drawing can be edited in place when being referenced by another user
        ///</summary>
        public void Set_XRefEdit(bool Edit) 
		{
			this._i.XRefEdit = Edit;
		}

        ///<summary>
        ///Determines the visibility of xref-dependent layers and specifies if nested xref path changes are saved
        ///</summary>
        public bool XRefLayerVisibility => this._i.XRefLayerVisibility;

        ///<summary>
        ///Determines the visibility of xref-dependent layers and specifies if nested xref path changes are saved
        ///</summary>
        public void Set_XRefLayerVisibility(bool XRefLayerVis) 
		{
			this._i.XRefLayerVisibility = XRefLayerVis;
		}

        ///<summary>
        ///Determines whether to launch the parent application when plotting OLE objects
        ///</summary>
        public bool OLELaunch => this._i.OLELaunch;

        ///<summary>
        ///Determines whether to launch the parent application when plotting OLE objects
        ///</summary>
        public void Set_OLELaunch(bool Launch) 
		{
			this._i.OLELaunch = Launch;
		}

        ///<summary>
        ///Determines if symbol names may include extended character sets, or more than 31 characters
        ///</summary>
        public bool AllowLongSymbolNames => this._i.AllowLongSymbolNames;

        ///<summary>
        ///Determines if symbol names may include extended character sets, or more than 31 characters
        ///</summary>
        public void Set_AllowLongSymbolNames(bool LongNames) 
		{
			this._i.AllowLongSymbolNames = LongNames;
		}

        ///<summary>
        ///Toggles sorting of drawing objects by object selection
        ///</summary>
        public bool ObjectSortBySelection => this._i.ObjectSortBySelection;

        ///<summary>
        ///Toggles sorting of drawing objects by object selection
        ///</summary>
        public void Set_ObjectSortBySelection(bool ObjectSortBySelection) 
		{
			this._i.ObjectSortBySelection = ObjectSortBySelection;
		}

        ///<summary>
        ///Toggles sorting of drawing objects by object snap
        ///</summary>
        public bool ObjectSortBySnap => this._i.ObjectSortBySnap;

        ///<summary>
        ///Toggles sorting of drawing objects by object snap
        ///</summary>
        public void Set_ObjectSortBySnap(bool ObjectSortBySnap) 
		{
			this._i.ObjectSortBySnap = ObjectSortBySnap;
		}

        ///<summary>
        ///Toggles sorting of drawing objects by redraw order
        ///</summary>
        public bool ObjectSortByRedraws => this._i.ObjectSortByRedraws;

        ///<summary>
        ///Toggles sorting of drawing objects by redraw order
        ///</summary>
        public void Set_ObjectSortByRedraws(bool ObjectSortByRedraws) 
		{
			this._i.ObjectSortByRedraws = ObjectSortByRedraws;
		}

        ///<summary>
        ///Toggles sorting of drawing objects by regeneration order
        ///</summary>
        public bool ObjectSortByRegens => this._i.ObjectSortByRegens;

        ///<summary>
        ///Toggles sorting of drawing objects by regeneration order
        ///</summary>
        public void Set_ObjectSortByRegens(bool ObjectSortByRegens) 
		{
			this._i.ObjectSortByRegens = ObjectSortByRegens;
		}

        ///<summary>
        ///Toggles sorting of drawing objects by plotting order
        ///</summary>
        public bool ObjectSortByPlotting => this._i.ObjectSortByPlotting;

        ///<summary>
        ///Toggles sorting of drawing objects by plotting order
        ///</summary>
        public void Set_ObjectSortByPlotting(bool ObjectSortByPlotting) 
		{
			this._i.ObjectSortByPlotting = ObjectSortByPlotting;
		}

        ///<summary>
        ///Toggles sorting of drawing objects by PostScript output order
        ///</summary>
        public bool ObjectSortByPSOutput => this._i.ObjectSortByPSOutput;

        ///<summary>
        ///Toggles sorting of drawing objects by PostScript output order
        ///</summary>
        public void Set_ObjectSortByPSOutput(bool ObjectSortByPSOutput) 
		{
			this._i.ObjectSortByPSOutput = ObjectSortByPSOutput;
		}

        ///<summary>
        ///Specifies the number of contour lines (isolines) per surface on objects
        ///</summary>
        public void Set_ContourLinesPerSurface(int ContourLinesPerSurface) 
		{
			this._i.ContourLinesPerSurface = ContourLinesPerSurface;
		}

        ///<summary>
        ///Specifies the number of contour lines (isolines) per surface on objects
        ///</summary>
        public int ContourLinesPerSurface => this._i.ContourLinesPerSurface;

        ///<summary>
        ///Controls whether silhouette curves of solid objects are displayed in Wireframe mode
        ///</summary>
        public void Set_DisplaySilhouette(bool DisplaySilhouette) 
		{
			this._i.DisplaySilhouette = DisplaySilhouette;
		}

        ///<summary>
        ///Controls whether silhouette curves of solid objects are displayed in Wireframe mode
        ///</summary>
        public bool DisplaySilhouette => this._i.DisplaySilhouette;

        ///<summary>
        /// Specifies the maximum number of active viewports. The maximum number of active viewports; 2 <= MaxActiveViewports <= 48 
        ///</summary>
        public void Set_MaxActiveViewports(int MaxActiveViewports) 
		{
			this._i.MaxActiveViewports = MaxActiveViewports;
		}

        ///<summary>
        /// Specifies the maximum number of active viewports
        ///</summary>
        public int MaxActiveViewports => this._i.MaxActiveViewports;

        ///<summary>
        ///Specifies the smoothness of shaded, rendered, and hidden line-removed objects
        ///</summary>
        public void Set_RenderSmoothness(double RenderSmoothness) 
		{
			this._i.RenderSmoothness = RenderSmoothness;
		}

        ///<summary>
        ///Specifies the smoothness of shaded, rendered, and hidden line-removed objects
        ///</summary>
        public double RenderSmoothness => this._i.RenderSmoothness;

        ///<summary>
        ///Specifies the number of line segments to be generated for each polyline curve
        ///</summary>
        public void Set_SegmentPerPolyline(int SegmentPerPolyline) 
		{
			this._i.SegmentPerPolyline = SegmentPerPolyline;
		}

        ///<summary>
        ///Specifies the number of line segments to be generated for each polyline curve
        ///</summary>
        public int SegmentPerPolyline => this._i.SegmentPerPolyline;

        ///<summary>
        ///Toggles the display of frames around the multileader text content with a text box or for text objects instead of displaying the text itself
        ///</summary>
        public void Set_TextFrameDisplay(bool TextFrameDisplay) 
		{
			this._i.TextFrameDisplay = TextFrameDisplay;
		}

        ///<summary>
        ///Toggles the display of frames around the multileader text content with a text box or for text objects instead of displaying the text itself
        ///</summary>
        public bool TextFrameDisplay => this._i.TextFrameDisplay;

        ///<summary>
        ///Specifies the lineweight of an individual object or the default lineweight for the drawing
        ///</summary>
        public void Set_Lineweight(Autodesk.AutoCAD.Interop.Common.AcLineWeight Lineweight) 
		{
			this._i.Lineweight = Lineweight;
		}

        ///<summary>
        ///Specifies the lineweight of an individual object or the default lineweight for the drawing
        ///</summary>
        public dynamic Lineweight => this._i.Lineweight;

        ///<summary>
        ///Specifies whether lineweights are displayed in model space for the drawing
        ///</summary>
        public void Set_LineWeightDisplay(bool Path) 
		{
			this._i.LineWeightDisplay = Path;
		}

        ///<summary>
        ///Specifies whether lineweights are displayed in model space for the drawing
        ///</summary>
        public bool LineWeightDisplay => this._i.LineWeightDisplay;
	}
}
