namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileLabelSet _i;
		internal AeccProfileLabelSet(object AeccProfileLabelSet_object) 
		{
			this._i = AeccProfileLabelSet_object as Autodesk.AECC.Interop.Land.IAeccProfileLabelSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelSet => this._i.MajorStationLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelSet => this._i.MinorStationLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic GeometryPointLabelSet => this._i.GeometryPointLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelSet => this._i.LineLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreaksLabelSet => this._i.GradeBreaksLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic SagCurvesLabelSet => this._i.SagCurvesLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic CrestCurvesLabelSet => this._i.CrestCurvesLabelSet;
	}
}
