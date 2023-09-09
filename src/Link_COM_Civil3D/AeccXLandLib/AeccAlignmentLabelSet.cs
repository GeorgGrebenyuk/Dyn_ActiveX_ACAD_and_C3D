namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentLabelSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentLabelSet _i;
		internal AeccAlignmentLabelSet(object AeccAlignmentLabelSet_object) 
		{
			this._i = AeccAlignmentLabelSet_object as Autodesk.AECC.Interop.Land.IAeccAlignmentLabelSet;
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
		public dynamic StationEquationLabelSet => this._i.StationEquationLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeedLabelSet => this._i.DesignSpeedLabelSet;
	}
}
