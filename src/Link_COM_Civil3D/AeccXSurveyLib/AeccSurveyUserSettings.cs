namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyUserSettings 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyUserSettings _i;
		internal AeccSurveyUserSettings(object AeccSurveyUserSettings_object) 
		{
			this._i = AeccSurveyUserSettings_object as Autodesk.AECC.Interop.Survey.IAeccSurveyUserSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string CurrentEquipmentDatabase => this._i.CurrentEquipmentDatabase;

		///<summary>
		///
		///</summary>
		public void Set_CurrentEquipmentDatabase(string pVal) 
		{
			this._i.CurrentEquipmentDatabase = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EquipmentDatabasePath => this._i.EquipmentDatabasePath;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentDatabasePath(string pVal) 
		{
			this._i.EquipmentDatabasePath = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurrentEquipment => this._i.CurrentEquipment;

		///<summary>
		///
		///</summary>
		public void Set_CurrentEquipment(string pVal) 
		{
			this._i.CurrentEquipment = pVal;
		}

		///<summary>
		///
		///</summary>
		public string FigurePrefixDatabasePath => this._i.FigurePrefixDatabasePath;

		///<summary>
		///
		///</summary>
		public void Set_FigurePrefixDatabasePath(string pVal) 
		{
			this._i.FigurePrefixDatabasePath = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurrentFigurePrefixDatabase => this._i.CurrentFigurePrefixDatabase;

		///<summary>
		///
		///</summary>
		public void Set_CurrentFigurePrefixDatabase(string pVal) 
		{
			this._i.CurrentFigurePrefixDatabase = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseExternalEditor => this._i.UseExternalEditor;

		///<summary>
		///
		///</summary>
		public void Set_UseExternalEditor(bool pVal) 
		{
			this._i.UseExternalEditor = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ExternalEditor => this._i.ExternalEditor;

		///<summary>
		///
		///</summary>
		public void Set_ExternalEditor(string pVal) 
		{
			this._i.ExternalEditor = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowInteractiveGraphics => this._i.ShowInteractiveGraphics;

		///<summary>
		///
		///</summary>
		public void Set_ShowInteractiveGraphics(bool pVal) 
		{
			this._i.ShowInteractiveGraphics = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EraseAllSurveyPoints => this._i.EraseAllSurveyPoints;

		///<summary>
		///
		///</summary>
		public void Set_EraseAllSurveyPoints(bool pVal) 
		{
			this._i.EraseAllSurveyPoints = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EraseAllObservations => this._i.EraseAllObservations;

		///<summary>
		///
		///</summary>
		public void Set_EraseAllObservations(bool pVal) 
		{
			this._i.EraseAllObservations = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EraseAllFigures => this._i.EraseAllFigures;

		///<summary>
		///
		///</summary>
		public void Set_EraseAllFigures(bool pVal) 
		{
			this._i.EraseAllFigures = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool InsertNetworkObject => this._i.InsertNetworkObject;

		///<summary>
		///
		///</summary>
		public void Set_InsertNetworkObject(bool pVal) 
		{
			this._i.InsertNetworkObject = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool InsertFigureObjects => this._i.InsertFigureObjects;

		///<summary>
		///
		///</summary>
		public void Set_InsertFigureObjects(bool pVal) 
		{
			this._i.InsertFigureObjects = pVal;
		}

		///<summary>
		///
		///</summary>
		public string SiteForLotlineFigures => this._i.SiteForLotlineFigures;

		///<summary>
		///
		///</summary>
		public void Set_SiteForLotlineFigures(string pVal) 
		{
			this._i.SiteForLotlineFigures = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool InsertCivil3DPoints => this._i.InsertCivil3DPoints;

		///<summary>
		///
		///</summary>
		public void Set_InsertCivil3DPoints(bool pVal) 
		{
			this._i.InsertCivil3DPoints = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ExportFiguresWithNetwork => this._i.ExportFiguresWithNetwork;

		///<summary>
		///
		///</summary>
		public void Set_ExportFiguresWithNetwork(bool pVal) 
		{
			this._i.ExportFiguresWithNetwork = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ExportPointNumbers => this._i.ExportPointNumbers;

		///<summary>
		///
		///</summary>
		public void Set_ExportPointNumbers(bool pVal) 
		{
			this._i.ExportPointNumbers = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ExportPointData => this._i.ExportPointData;

		///<summary>
		///
		///</summary>
		public void Set_ExportPointData(bool pVal) 
		{
			this._i.ExportPointData = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool AutomaticPanAndZoom => this._i.AutomaticPanAndZoom;

		///<summary>
		///
		///</summary>
		public void Set_AutomaticPanAndZoom(bool pVal) 
		{
			this._i.AutomaticPanAndZoom = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowBacksightLine => this._i.ShowBacksightLine;

		///<summary>
		///
		///</summary>
		public void Set_ShowBacksightLine(bool pVal) 
		{
			this._i.ShowBacksightLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowBacksightPrism => this._i.ShowBacksightPrism;

		///<summary>
		///
		///</summary>
		public void Set_ShowBacksightPrism(bool pVal) 
		{
			this._i.ShowBacksightPrism = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowStationTransit => this._i.ShowStationTransit;

		///<summary>
		///
		///</summary>
		public void Set_ShowStationTransit(bool pVal) 
		{
			this._i.ShowStationTransit = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowForesightLine => this._i.ShowForesightLine;

		///<summary>
		///
		///</summary>
		public void Set_ShowForesightLine(bool pVal) 
		{
			this._i.ShowForesightLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowForesightPrism => this._i.ShowForesightPrism;

		///<summary>
		///
		///</summary>
		public void Set_ShowForesightPrism(bool pVal) 
		{
			this._i.ShowForesightPrism = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowBaseline => this._i.ShowBaseline;

		///<summary>
		///
		///</summary>
		public void Set_ShowBaseline(bool pVal) 
		{
			this._i.ShowBaseline = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowBaselinePrism => this._i.ShowBaselinePrism;

		///<summary>
		///
		///</summary>
		public void Set_ShowBaselinePrism(bool pVal) 
		{
			this._i.ShowBaselinePrism = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowBaselineOffsetLine => this._i.ShowBaselineOffsetLine;

		///<summary>
		///
		///</summary>
		public void Set_ShowBaselineOffsetLine(bool pVal) 
		{
			this._i.ShowBaselineOffsetLine = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowCurrentFigureVertex => this._i.ShowCurrentFigureVertex;

		///<summary>
		///
		///</summary>
		public void Set_ShowCurrentFigureVertex(bool pVal) 
		{
			this._i.ShowCurrentFigureVertex = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BacksightLineColor => this._i.BacksightLineColor;

		///<summary>
		///
		///</summary>
		public void Put_BacksightLineColor(dynamic ppVal) 
		{
			this._i.BacksightLineColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BacksightPrismColor => this._i.BacksightPrismColor;

		///<summary>
		///
		///</summary>
		public void Put_BacksightPrismColor(dynamic ppVal) 
		{
			this._i.BacksightPrismColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic StationTransitColor => this._i.StationTransitColor;

		///<summary>
		///
		///</summary>
		public void Put_StationTransitColor(dynamic ppVal) 
		{
			this._i.StationTransitColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ForesightLineColor => this._i.ForesightLineColor;

		///<summary>
		///
		///</summary>
		public void Put_ForesightLineColor(dynamic ppVal) 
		{
			this._i.ForesightLineColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ForesightPrismColor => this._i.ForesightPrismColor;

		///<summary>
		///
		///</summary>
		public void Put_ForesightPrismColor(dynamic ppVal) 
		{
			this._i.ForesightPrismColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BaselineColor => this._i.BaselineColor;

		///<summary>
		///
		///</summary>
		public void Put_BaselineColor(dynamic ppVal) 
		{
			this._i.BaselineColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BaselinePrismColor => this._i.BaselinePrismColor;

		///<summary>
		///
		///</summary>
		public void Put_BaselinePrismColor(dynamic ppVal) 
		{
			this._i.BaselinePrismColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BaselineOffsetLineColor => this._i.BaselineOffsetLineColor;

		///<summary>
		///
		///</summary>
		public void Put_BaselineOffsetLineColor(dynamic ppVal) 
		{
			this._i.BaselineOffsetLineColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CurrentFigureVertexColor => this._i.CurrentFigureVertexColor;

		///<summary>
		///
		///</summary>
		public void Put_CurrentFigureVertexColor(dynamic ppVal) 
		{
			this._i.CurrentFigureVertexColor = ppVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowNetworkInNetworkPreview => this._i.ShowNetworkInNetworkPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowNetworkInNetworkPreview(bool pVal) 
		{
			this._i.ShowNetworkInNetworkPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowSideshotsInNetworkPreview => this._i.ShowSideshotsInNetworkPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowSideshotsInNetworkPreview(bool pVal) 
		{
			this._i.ShowSideshotsInNetworkPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowPointsInNetworkPreview => this._i.ShowPointsInNetworkPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowPointsInNetworkPreview(bool pVal) 
		{
			this._i.ShowPointsInNetworkPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowFiguresInNetworkPreview => this._i.ShowFiguresInNetworkPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowFiguresInNetworkPreview(bool pVal) 
		{
			this._i.ShowFiguresInNetworkPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowSideshotsInSetupPreview => this._i.ShowSideshotsInSetupPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowSideshotsInSetupPreview(bool pVal) 
		{
			this._i.ShowSideshotsInSetupPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowPointsInSetupPreview => this._i.ShowPointsInSetupPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowPointsInSetupPreview(bool pVal) 
		{
			this._i.ShowPointsInSetupPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowFiguresInSetupPreview => this._i.ShowFiguresInSetupPreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowFiguresInSetupPreview(bool pVal) 
		{
			this._i.ShowFiguresInSetupPreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowFigureInFigurePreview => this._i.ShowFigureInFigurePreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowFigureInFigurePreview(bool pVal) 
		{
			this._i.ShowFigureInFigurePreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowPointsInFigurePreview => this._i.ShowPointsInFigurePreview;

		///<summary>
		///
		///</summary>
		public void Set_ShowPointsInFigurePreview(bool pVal) 
		{
			this._i.ShowPointsInFigurePreview = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DefaultFigureLayer => this._i.DefaultFigureLayer;

		///<summary>
		///
		///</summary>
		public void Set_DefaultFigureLayer(string pVal) 
		{
			this._i.DefaultFigureLayer = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DefaultFigureStyle => this._i.DefaultFigureStyle;

		///<summary>
		///
		///</summary>
		public void Set_DefaultFigureStyle(string pVal) 
		{
			this._i.DefaultFigureStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public double PreviewVerticalExaggeration => this._i.PreviewVerticalExaggeration;

		///<summary>
		///
		///</summary>
		public void Set_PreviewVerticalExaggeration(double pVal) 
		{
			this._i.PreviewVerticalExaggeration = pVal;
		}
	}
}
