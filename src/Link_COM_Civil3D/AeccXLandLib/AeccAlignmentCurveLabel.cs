namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentCurveLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentCurveLabel _i;
		internal AeccAlignmentCurveLabel(object AeccAlignmentCurveLabel_object) 
		{
			this._i = AeccAlignmentCurveLabel_object as Autodesk.AECC.Interop.Land.IAeccAlignmentCurveLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
