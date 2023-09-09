namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileLabelStyleSet _i;
		internal AeccProfileLabelStyleSet(object AeccProfileLabelStyleSet_object) 
		{
			this._i = AeccProfileLabelStyleSet_object as Autodesk.AECC.Interop.Land.IAeccProfileLabelStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelStyleSet => this._i.MajorStationLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelStyleSet => this._i.MinorStationLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic GeometryPointLabelStyleSet => this._i.GeometryPointLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyleSet => this._i.LineLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreaksLabelStyleSet => this._i.GradeBreaksLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic SagCurvesLabelStyleSet => this._i.SagCurvesLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic CrestCurvesLabelStyleSet => this._i.CrestCurvesLabelStyleSet;
	}
}
