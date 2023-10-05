using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DynAXDBLib 
{

    ///<summary>
    /// A named collection of plot settings
    ///</summary>
    public class AcadPlotConfiguration 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPlotConfiguration _i;
		internal AcadPlotConfiguration(object AcadPlotConfiguration_object) 
		{
			this._i = AcadPlotConfiguration_object as Autodesk.AutoCAD.Interop.Common.AcadPlotConfiguration;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Get a plot configuration for Layout
		/// </summary>
		/// <param name="AcadLayout"></param>
		/// <exception cref="System.Exception"></exception>
		public AcadPlotConfiguration (AcadLayout AcadLayout)
		{
            this._i = AcadLayout._i as Autodesk.AutoCAD.Interop.Common.AcadPlotConfiguration;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        ///
        ///</summary>
        public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pName) 
		{
			this._i.Name = pName;
		}

        ///<summary>
        /// Specifies the plotter configuration name
        ///</summary>
        public string ConfigName => this._i.ConfigName;

        ///<summary>
        /// Specifies the plotter configuration name
        ///</summary>
        public void Set_ConfigName(string pName) 
		{
			this._i.ConfigName = pName;
		}

        ///<summary>
        /// Specifies the paper size by name
        ///</summary>
        public string CanonicalMediaName => this._i.CanonicalMediaName;

        ///<summary>
        ///Specifies the paper size by name
        ///</summary>
        public void Set_CanonicalMediaName(string pName)
		{
			this._i.CanonicalMediaName = pName;
		}

        ///<summary>
        ///Specifies the units for the display of layout or plot configuration properties
        ///</summary>
        public object PaperUnits => this._i.PaperUnits;

        ///<summary>
        ///Specifies the units for the display of layout or plot configuration properties
        ///</summary>
        public void Set_PaperUnits(Autodesk.AutoCAD.Interop.Common.AcPlotPaperUnits pPaperUnits)
		{
			this._i.PaperUnits = pPaperUnits;
		}

        ///<summary>
        ///Specifies if the viewport borders are to be plotted
        ///</summary>
        public bool PlotViewportBorders => this._i.PlotViewportBorders;

        ///<summary>
        ///Specifies if the viewport borders are to be plotted
        ///</summary>
        public void Set_PlotViewportBorders(bool pViewportBorders)
		{
			this._i.PlotViewportBorders = pViewportBorders;
		}

        ///<summary>
        ///Specifies whether or not plot styles and plot style names are displayed in the drawing
        ///</summary>
        public bool ShowPlotStyles => this._i.ShowPlotStyles;

        ///<summary>
        ///Specifies whether or not plot styles and plot style names are displayed in the drawing
        ///</summary>
        public void Set_ShowPlotStyles(bool pStyles)
		{
			this._i.ShowPlotStyles = pStyles;
		}

        ///<summary>
        ///Specifies the rotation angle for the layout or plot configuration
        ///</summary>
        public object PlotRotation => this._i.PlotRotation;

        ///<summary>
        ///Specifies the rotation angle for the layout or plot configuration
        ///</summary>
        public void Set_PlotRotation(Autodesk.AutoCAD.Interop.Common.AcPlotRotation pRotation)
		{
			this._i.PlotRotation = pRotation;
		}

        ///<summary>
        ///Specifies the centering of the plot on the media
        ///</summary>
        public bool CenterPlot => this._i.CenterPlot;

        ///<summary>
        ///Specifies the centering of the plot on the media
        ///</summary>
        public void Set_CenterPlot(bool pCentered)
		{
			this._i.CenterPlot = pCentered;
		}

        ///<summary>
        ///Specifies if objects are to be hidden during a plot
        ///</summary>
        public bool PlotHidden => this._i.PlotHidden;

        ///<summary>
        ///Specifies if objects are to be hidden during a plot
        ///</summary>
        public void Set_PlotHidden(bool pHidden)
		{
			this._i.PlotHidden = pHidden;
		}

        ///<summary>
        ///Specifies the type of layout or plot configuration. 
        ///</summary>
        public object PlotType => this._i.PlotType;

        ///<summary>
        ///Specifies the type of layout or plot configuration. 
        ///</summary>
        public void Set_PlotType(Autodesk.AutoCAD.Interop.Common.AcPlotType pType)
		{
			this._i.PlotType = pType;
		}

        ///<summary>
        ///Specifies the name of the view to plot
        ///</summary>
        public string ViewToPlot => this._i.ViewToPlot;

        ///<summary>
        ///Specifies the name of the view to plot
        ///</summary>
        public void Set_ViewToPlot(string pName)
		{
			this._i.ViewToPlot = pName;
		}

        ///<summary>
        ///Specifies if the plot is to use a standard or custom scale
        ///</summary>
        public bool UseStandardScale => this._i.UseStandardScale;

        ///<summary>
        ///Specifies if the plot is to use a standard or custom scale
        ///</summary>
        public void Set_UseStandardScale(bool pUseStdScale)
		{
			this._i.UseStandardScale = pUseStdScale;
		}

        ///<summary>
        ///Specifies the standard scale for the layout, viewport, or plot configuration
        ///</summary>
        public object StandardScale => this._i.StandardScale;

        ///<summary>
        ///Specifies the standard scale for the layout, viewport, or plot configuration
        ///</summary>
        public void Set_StandardScale(Autodesk.AutoCAD.Interop.Common.AcPlotScale pStdScale)
		{
			this._i.StandardScale = pStdScale;
		}

        ///<summary>
        /// Gets the custom scale for a layout or plot configuration
        ///</summary>
        public List<double> GetCustomScale()
		{
			double Numerator;
			double Denominator;

			this._i.GetCustomScale(out Numerator, out Denominator);
			return new List<double> { Numerator, Denominator };
		}

        /// <summary>
        /// Sets the custom scale for a layout or plot configuration
        /// </summary>
        /// <param name="Numerator">A positive number representing the numerator in the scale ratio. This value represents the number of inches or mm for the scale</param>
        /// <param name="Denominator">A positive number representing the denominator in the scale ratio. This value represents the number of drawing units for the scale</param>
        public void SetCustomScale(double Numerator, double Denominator)
		{
			this._i.SetCustomScale(Numerator, Denominator);
		}

        ///<summary>
        ///Specifies if the lineweight is scaled with the rest of the geometry when a layout is printed
        ///</summary>
        public bool ScaleLineweights => this._i.ScaleLineweights;

        ///<summary>
        ///Specifies if the lineweight is scaled with the rest of the geometry when a layout is printed
        ///</summary>
        public void Set_ScaleLineweights(bool pScale)
		{
			this._i.ScaleLineweights = pScale;
		}

        ///<summary>
        ///Specifies whether objects plot with the lineweights they are assigned in the plot file, or with the lineweights in the drawing file
        ///</summary>
        public bool PlotWithLineweights => this._i.PlotWithLineweights;

        ///<summary>
        ///Specifies whether objects plot with the lineweights they are assigned in the plot file, or with the lineweights in the drawing file
        ///</summary>
        public void Set_PlotWithLineweights(bool pPlot)
		{
			this._i.PlotWithLineweights = pPlot;
		}

        ///<summary>
        ///Specifies if all geometry in paper space viewports is plotted first
        ///</summary>
        public bool PlotViewportsFirst => this._i.PlotViewportsFirst;

        ///<summary>
        ///Specifies if all geometry in paper space viewports is plotted first
        ///</summary>
        public void Set_PlotViewportsFirst(bool pViewportsFirst)
		{
			this._i.PlotViewportsFirst = pViewportsFirst;
		}

        ///<summary>
        ///Specifies the style sheet for the layout or plot configuration
        ///</summary>
        public string StyleSheet => this._i.StyleSheet;

        ///<summary>
        ///Specifies the style sheet for the layout or plot configuration
        ///</summary>
        public void Set_StyleSheet(string pName)
		{
			this._i.StyleSheet = pName;
		}

        ///<summary>
        ///Gets the margins for the layout or plot configuration
        ///</summary>
        public List<object> GetPaperMargins()
		{
			object LowerLeft;
			object UpperRight;

			this._i.GetPaperMargins(out LowerLeft, out UpperRight);
			return new List<object> { LowerLeft, UpperRight };
		}

        ///<summary>
        ///Gets the width and height of the configured paper
        ///</summary>
        public List<double> GetPaperSize()
		{
			double Width;
			double Height;

			this._i.GetPaperSize(out Width, out Height);
			return new List<double> { Width, Height };
		}

        ///<summary>
        ///Specifies the origin of the layout or plot configuration in WCS coordinates
        ///</summary>
        public double[] PlotOrigin => this._i.PlotOrigin;

        /// <summary>
        /// Specifies the origin of the layout or plot configuration in WCS coordinates
        /// </summary>
        /// <param name="pOrigin">The X and Y values representing the origin relative to the lower-left corner of the media</param>
        public void Set_PlotOrigin(double[] pOrigin)
		{
			this._i.PlotOrigin = pOrigin;
		}

        ///<summary>
        ///Gets the coordinates that define the portion of the layout to plot
        ///</summary>
        public List<object> GetWindowToPlot()
		{
			object LowerLeft;
			object UpperRight;

			this._i.GetWindowToPlot(out LowerLeft, out UpperRight);
			return new List<object> { LowerLeft, UpperRight };
		}

        ///<summary>
        ///Sets the coordinates that define the portion of the layout to plot
        ///</summary>
        public void SetWindowToPlot(object LowerLeft, object UpperRight)
		{
			this._i.SetWindowToPlot(LowerLeft, UpperRight);
		}

        ///<summary>
        ///Specifies whether or not to plot using the plot styles that are applied to objects and defined in the plot style table
        ///</summary>
        public bool PlotWithPlotStyles => this._i.PlotWithPlotStyles;

        ///<summary>
        ///Specifies whether or not to plot using the plot styles that are applied to objects and defined in the plot style table
        ///</summary>
        public void Set_PlotWithPlotStyles(bool pStyles)
		{
			this._i.PlotWithPlotStyles = pStyles;
		}

        ///<summary>
        ///Specifies whether a plot configuration applies to model space or to all layouts
        ///</summary>
        public bool ModelType => this._i.ModelType;

        /// <summary>
        /// Copies the settings for a plot configuration
        /// </summary>
        /// <param name="pPlotConfig"></param>
        public void CopyFrom(AcadPlotConfiguration pPlotConfig)
		{
			this._i.CopyFrom(pPlotConfig._i);
		}

        ///<summary>
        ///Gets all available canonical media names for the specified plot device
        ///</summary>
        public object GetCanonicalMediaNames => this._i.GetCanonicalMediaNames();

        ///<summary>
        ///Gets all available plot device names
        ///</summary>
        public object GetPlotDeviceNames => this._i.GetPlotDeviceNames();

        ///<summary>
        ///Gets all available plot style table names
        ///</summary>
        public object GetPlotStyleTableNames => this._i.GetPlotStyleTableNames();

        ///<summary>
        /// Updates the plot, canonical media, and plot style table information to reflect the current system state
        ///</summary>
        public void RefreshPlotDeviceInfo()
		{
			this._i.RefreshPlotDeviceInfo();
		}

        ///<summary>
        /// Gets the localized version of the canonical media name
        ///</summary>
        public string GetLocaleMediaName(string Name)
		{
			return this._i.GetLocaleMediaName(Name);
		}
	}
}
