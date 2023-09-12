using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DynAXDBLib 
{

	///<summary>
	///
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
		///
		///</summary>
		public string ConfigName => this._i.ConfigName;

		///<summary>
		///
		///</summary>
		public void Set_ConfigName(string pName) 
		{
			this._i.ConfigName = pName;
		}

		///<summary>
		///
		///</summary>
		public string CanonicalMediaName => this._i.CanonicalMediaName;

		///<summary>
		///
		///</summary>
		public void Set_CanonicalMediaName(string pName)
		{
			this._i.CanonicalMediaName = pName;
		}

		///<summary>
		///
		///</summary>
		public object PaperUnits => this._i.PaperUnits;

		///<summary>
		///
		///</summary>
		public void Set_PaperUnits(Autodesk.AutoCAD.Interop.Common.AcPlotPaperUnits pPaperUnits)
		{
			this._i.PaperUnits = pPaperUnits;
		}

		///<summary>
		///
		///</summary>
		public bool PlotViewportBorders => this._i.PlotViewportBorders;

		///<summary>
		///
		///</summary>
		public void Set_PlotViewportBorders(bool pViewportBorders)
		{
			this._i.PlotViewportBorders = pViewportBorders;
		}

		///<summary>
		///
		///</summary>
		public bool ShowPlotStyles => this._i.ShowPlotStyles;

		///<summary>
		///
		///</summary>
		public void Set_ShowPlotStyles(bool pStyles)
		{
			this._i.ShowPlotStyles = pStyles;
		}

		///<summary>
		///
		///</summary>
		public object PlotRotation => this._i.PlotRotation;

		///<summary>
		///
		///</summary>
		public void Set_PlotRotation(Autodesk.AutoCAD.Interop.Common.AcPlotRotation pRotation)
		{
			this._i.PlotRotation = pRotation;
		}

		///<summary>
		///
		///</summary>
		public bool CenterPlot => this._i.CenterPlot;

		///<summary>
		///
		///</summary>
		public void Set_CenterPlot(bool pCentered)
		{
			this._i.CenterPlot = pCentered;
		}

		///<summary>
		///
		///</summary>
		public bool PlotHidden => this._i.PlotHidden;

		///<summary>
		///
		///</summary>
		public void Set_PlotHidden(bool pHidden)
		{
			this._i.PlotHidden = pHidden;
		}

		///<summary>
		///
		///</summary>
		public object PlotType => this._i.PlotType;

		///<summary>
		///
		///</summary>
		public void Set_PlotType(Autodesk.AutoCAD.Interop.Common.AcPlotType pType)
		{
			this._i.PlotType = pType;
		}

		///<summary>
		///
		///</summary>
		public string ViewToPlot => this._i.ViewToPlot;

		///<summary>
		///
		///</summary>
		public void Set_ViewToPlot(string pName)
		{
			this._i.ViewToPlot = pName;
		}

		///<summary>
		///
		///</summary>
		public bool UseStandardScale => this._i.UseStandardScale;

		///<summary>
		///
		///</summary>
		public void Set_UseStandardScale(bool pUseStdScale)
		{
			this._i.UseStandardScale = pUseStdScale;
		}

		///<summary>
		///
		///</summary>
		public object StandardScale => this._i.StandardScale;

		///<summary>
		///
		///</summary>
		public void Set_StandardScale(Autodesk.AutoCAD.Interop.Common.AcPlotScale pStdScale)
		{
			this._i.StandardScale = pStdScale;
		}

		///<summary>
		///
		///</summary>
		public List<double> GetCustomScale()
		{
			double Numerator;
			double Denominator;

			this._i.GetCustomScale(out Numerator, out Denominator);
			return new List<double> { Numerator, Denominator };
		}

		///<summary>
		///
		///</summary>
		public void SetCustomScale(double Numerator, double Denominator)
		{
			this._i.SetCustomScale(Numerator, Denominator);
		}

		///<summary>
		///
		///</summary>
		public bool ScaleLineweights => this._i.ScaleLineweights;

		///<summary>
		///
		///</summary>
		public void Set_ScaleLineweights(bool pScale)
		{
			this._i.ScaleLineweights = pScale;
		}

		///<summary>
		///
		///</summary>
		public bool PlotWithLineweights => this._i.PlotWithLineweights;

		///<summary>
		///
		///</summary>
		public void Set_PlotWithLineweights(bool pPlot)
		{
			this._i.PlotWithLineweights = pPlot;
		}

		///<summary>
		///
		///</summary>
		public bool PlotViewportsFirst => this._i.PlotViewportsFirst;

		///<summary>
		///
		///</summary>
		public void Set_PlotViewportsFirst(bool pViewportsFirst)
		{
			this._i.PlotViewportsFirst = pViewportsFirst;
		}

		///<summary>
		///
		///</summary>
		public string StyleSheet => this._i.StyleSheet;

		///<summary>
		///
		///</summary>
		public void Set_StyleSheet(string pName)
		{
			this._i.StyleSheet = pName;
		}

		///<summary>
		///
		///</summary>
		public List<object> GetPaperMargins()
		{
			object LowerLeft;
			object UpperRight;

			this._i.GetPaperMargins(out LowerLeft, out UpperRight);
			return new List<object> { LowerLeft, UpperRight };
		}

		///<summary>
		///
		///</summary>
		public List<double> GetPaperSize()
		{
			double Width;
			double Height;

			this._i.GetPaperSize(out Width, out Height);
			return new List<double> { Width, Height };
		}

		///<summary>
		///
		///</summary>
		public object PlotOrigin => this._i.PlotOrigin;

		///<summary>
		///
		///</summary>
		public void Set_PlotOrigin(object pOrigin)
		{
			this._i.PlotOrigin = pOrigin;
		}

		///<summary>
		///
		///</summary>
		public List<object> GetWindowToPlot()
		{
			object LowerLeft;
			object UpperRight;

			this._i.GetWindowToPlot(out LowerLeft, out UpperRight);
			return new List<object> { LowerLeft, UpperRight };
		}

		///<summary>
		///
		///</summary>
		public void SetWindowToPlot(object LowerLeft, object UpperRight)
		{
			this._i.SetWindowToPlot(LowerLeft, UpperRight);
		}

		///<summary>
		///
		///</summary>
		public bool PlotWithPlotStyles => this._i.PlotWithPlotStyles;

		///<summary>
		///
		///</summary>
		public void Set_PlotWithPlotStyles(bool pStyles)
		{
			this._i.PlotWithPlotStyles = pStyles;
		}

		///<summary>
		///
		///</summary>
		public bool ModelType => this._i.ModelType;

		///<summary>
		///
		///</summary>
		public void CopyFrom(dynamic pPlotConfig)
		{
			this._i.CopyFrom(pPlotConfig);
		}

		///<summary>
		///
		///</summary>
		public object GetCanonicalMediaNames => this._i.GetCanonicalMediaNames();

		///<summary>
		///
		///</summary>
		public object GetPlotDeviceNames => this._i.GetPlotDeviceNames();

		///<summary>
		///
		///</summary>
		public object GetPlotStyleTableNames => this._i.GetPlotStyleTableNames();

		///<summary>
		///
		///</summary>
		public void RefreshPlotDeviceInfo()
		{
			this._i.RefreshPlotDeviceInfo();
		}

		///<summary>
		///
		///</summary>
		public string GetLocaleMediaName(string Name)
		{
			return this._i.GetLocaleMediaName(Name);
		}
	}
}
