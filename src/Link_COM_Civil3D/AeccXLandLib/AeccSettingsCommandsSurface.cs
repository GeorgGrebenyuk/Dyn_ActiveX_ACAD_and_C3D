namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsSurface 
	{
		public AeccXLandLib.IAeccSettingsCommandsSurface _i;
		internal AeccSettingsCommandsSurface(object AeccSettingsCommandsSurface_object) 
		{
			this._i = AeccSettingsCommandsSurface_object as AeccXLandLib.IAeccSettingsCommandsSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddContourLabelingSettings => this._i.AddContourLabelingSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddContourLabelingGroupSettings => this._i.AddContourLabelingGroupSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddContourLabelingSingleSettings => this._i.AddContourLabelingSingleSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSpotElevLabelsOnGridSettings => this._i.AddSpotElevLabelsOnGridSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSurfaceDemFileSettings => this._i.AddSurfaceDemFileSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSlopeLabelSettings => this._i.AddSlopeLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSurfaceSpotElevLabelSettings => this._i.AddSurfaceSpotElevLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic CatchmentAreaSettings => this._i.CatchmentAreaSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateSurfaceSettings => this._i.CreateSurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateSurfaceGridFromDEMSettings => this._i.CreateSurfaceGridFromDEMSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateSurfaceReferenceSettings => this._i.CreateSurfaceReferenceSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateSurfaceWaterdropSettings => this._i.CreateSurfaceWaterdropSettings;

		///<summary>
		///
		///</summary>
		public dynamic ImportGEDataSettings => this._i.ImportGEDataSettings;

		///<summary>
		///
		///</summary>
		public dynamic ImportGESurfaceSettings => this._i.ImportGESurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic ImportSurfaceSettings => this._i.ImportSurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic MoveBlocksToAttribElevSettings => this._i.MoveBlocksToAttribElevSettings;

		///<summary>
		///
		///</summary>
		public dynamic MoveBlocksToSurfaceSettings => this._i.MoveBlocksToSurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic MoveTextToElevationSettings => this._i.MoveTextToElevationSettings;

		///<summary>
		///
		///</summary>
		public dynamic SimplifySurfaceSettings => this._i.SimplifySurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceExportToDemSettings => this._i.SurfaceExportToDemSettings;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceExtractObjectsSettings => this._i.SurfaceExtractObjectsSettings;
	}
}
