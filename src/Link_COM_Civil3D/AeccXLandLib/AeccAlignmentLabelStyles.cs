namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentLabelStyles _i;
		internal AeccAlignmentLabelStyles(object AeccAlignmentLabelStyles_object) 
		{
			this._i = AeccAlignmentLabelStyles_object as Autodesk.AECC.Interop.Land.IAeccAlignmentLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelStyles => this._i.MajorStationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelStyles => this._i.MinorStationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic GeometryPointLabelStyles => this._i.GeometryPointLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationLabelStyles => this._i.StationEquationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic TangentIntersectionLabelStyles => this._i.TangentIntersectionLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic StationOffsetLabelStyles => this._i.StationOffsetLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyles => this._i.LineLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyles => this._i.CurveLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic SpiralLabelStyles => this._i.SpiralLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeedLabelStyles => this._i.DesignSpeedLabelStyles;
	}
}
