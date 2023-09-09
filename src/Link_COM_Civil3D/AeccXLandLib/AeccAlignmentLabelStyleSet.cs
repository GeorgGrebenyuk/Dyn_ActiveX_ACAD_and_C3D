namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentLabelStyleSet _i;
		internal AeccAlignmentLabelStyleSet(object AeccAlignmentLabelStyleSet_object) 
		{
			this._i = AeccAlignmentLabelStyleSet_object as Autodesk.AECC.Interop.Land.IAeccAlignmentLabelStyleSet;
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
		public dynamic StationEquationLabelStyleSet => this._i.StationEquationLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeedLabelStyleSet => this._i.DesignSpeedLabelStyleSet;
	}
}
