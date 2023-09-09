namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccDatabase 
	{
		public AeccXLandLib.IAeccDatabase _i;
		internal AeccDatabase(object AeccDatabase_object) 
		{
			this._i = AeccDatabase_object as AeccXLandLib.IAeccDatabase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfaceStyles => this._i.SurfaceStyles;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentStyles => this._i.AlignmentStyles;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewStyles => this._i.ProfileViewStyles;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineLabelStyles => this._i.SampleLineLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic SectionViewLabelStyles => this._i.SectionViewLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentLabelStyles => this._i.AlignmentLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceLabelStyles => this._i.SurfaceLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic PointLabelStyles => this._i.PointLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic ParcelLabelStyles => this._i.ParcelLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic ProfileLabelStyles => this._i.ProfileLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewLabelStyles => this._i.ProfileViewLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic LandProfileStyles => this._i.LandProfileStyles;

		///<summary>
		///
		///</summary>
		public dynamic ParcelStyles => this._i.ParcelStyles;

		///<summary>
		///
		///</summary>
		public dynamic PointStyles => this._i.PointStyles;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceTableStyles => this._i.SurfaceTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic ParcelTableStyles => this._i.ParcelTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentTableStyles => this._i.AlignmentTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic PointTableStyles => this._i.PointTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic Points => this._i.Points;

		///<summary>
		///
		///</summary>
		public dynamic PointDescriptionKeySets => this._i.PointDescriptionKeySets;

		///<summary>
		///
		///</summary>
		public dynamic PointGroups => this._i.PointGroups;

		///<summary>
		///
		///</summary>
		public dynamic Surfaces => this._i.Surfaces;

		///<summary>
		///
		///</summary>
		public dynamic SectionViewStyles => this._i.SectionViewStyles;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineStyles => this._i.SampleLineStyles;

		///<summary>
		///
		///</summary>
		public dynamic Sites => this._i.Sites;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewBandStyles => this._i.ProfileViewBandStyles;

		///<summary>
		///
		///</summary>
		public dynamic SectionViewBandStyles => this._i.SectionViewBandStyles;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewBandStyleSets => this._i.ProfileViewBandStyleSets;

		///<summary>
		///
		///</summary>
		public dynamic SectionViewBandStyleSets => this._i.SectionViewBandStyleSets;

		///<summary>
		///
		///</summary>
		public dynamic SectionStyles => this._i.SectionStyles;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyles => this._i.MarkerStyles;

		///<summary>
		///
		///</summary>
		public dynamic Settings => this._i.Settings;

		///<summary>
		///
		///</summary>
		public dynamic SectionLabelStyles => this._i.SectionLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentLabelStyleSets => this._i.AlignmentLabelStyleSets;

		///<summary>
		///
		///</summary>
		public dynamic ProfileLabelStyleSets => this._i.ProfileLabelStyleSets;

		///<summary>
		///
		///</summary>
		public dynamic SectionLabelStyleSets => this._i.SectionLabelStyleSets;

		///<summary>
		///
		///</summary>
		public dynamic SheetStyles => this._i.SheetStyles;

		///<summary>
		///
		///</summary>
		public dynamic GroupPlotStyles => this._i.GroupPlotStyles;

		///<summary>
		///
		///</summary>
		public dynamic GradingStyles => this._i.GradingStyles;

		///<summary>
		///
		///</summary>
		public dynamic PointUserDefinedPropertyClassifications => this._i.PointUserDefinedPropertyClassifications;

		///<summary>
		///
		///</summary>
		public dynamic ParcelUserDefinedPropertyClassifications => this._i.ParcelUserDefinedPropertyClassifications;

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameStyles => this._i.ViewFrameStyles;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineStyles => this._i.MatchLineStyles;

		///<summary>
		///
		///</summary>
		public void AddEvent(AeccXLandLib.AeccEventMessageType eventType,string strSource,string strDescription) 
		{
			this._i.AddEvent(eventType,strSource,strDescription);
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineStyles => this._i.FeatureLineStyles;

		///<summary>
		///
		///</summary>
		public dynamic GeneralNoteLabelStyles => this._i.GeneralNoteLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic GeneralLineLabelStyles => this._i.GeneralLineLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic GeneralCurveLabelStyles => this._i.GeneralCurveLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentsSiteless => this._i.AlignmentsSiteless;

		///<summary>
		///
		///</summary>
		public dynamic GeneralLabels => this._i.GeneralLabels;

		///<summary>
		///
		///</summary>
		public dynamic NoteLabels => this._i.NoteLabels;
	}
}
