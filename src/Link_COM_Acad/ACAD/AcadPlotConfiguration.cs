namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlotConfiguration 
	{
		public AXDBLib.IAcadPlotConfiguration _i;
		internal AcadPlotConfiguration(object AcadPlotConfiguration_object) 
		{
			this._i = AcadPlotConfiguration_object as AXDBLib.IAcadPlotConfiguration;
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
		public dynamic PaperUnits => this._i.PaperUnits;

		///<summary>
		///
		///</summary>
		public void Set_PaperUnits(AXDBLib.AcPlotPaperUnits pPaperUnits) 
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
		public dynamic PlotRotation => this._i.PlotRotation;

		///<summary>
		///
		///</summary>
		public void Set_PlotRotation(AXDBLib.AcPlotRotation pRotation) 
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
		public dynamic PlotType => this._i.PlotType;

		///<summary>
		///
		///</summary>
		public void Set_PlotType(AXDBLib.AcPlotType pType) 
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
		public dynamic StandardScale => this._i.StandardScale;

		///<summary>
		///
		///</summary>
		public void Set_StandardScale(AXDBLib.AcPlotScale pStdScale) 
		{
			this._i.StandardScale = pStdScale;
		}

		///<summary>
		///
		///</summary>
		public void GetCustomScale(out double Numerator,out double Denominator) 
		{
			this._i.GetCustomScale(out Numerator,out Denominator);
		}

		///<summary>
		///
		///</summary>
		public void SetCustomScale(double Numerator,double Denominator) 
		{
			this._i.SetCustomScale(Numerator,Denominator);
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
		public void GetPaperMargins(out object LowerLeft,out object UpperRight) 
		{
			this._i.GetPaperMargins(out LowerLeft,out UpperRight);
		}

		///<summary>
		///
		///</summary>
		public void GetPaperSize(out double Width,out double Height) 
		{
			this._i.GetPaperSize(out Width,out Height);
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
		public void GetWindowToPlot(out object LowerLeft,out object UpperRight) 
		{
			this._i.GetWindowToPlot(out LowerLeft,out UpperRight);
		}

		///<summary>
		///
		///</summary>
		public void SetWindowToPlot(object LowerLeft,object UpperRight) 
		{
			this._i.SetWindowToPlot(LowerLeft,UpperRight);
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
