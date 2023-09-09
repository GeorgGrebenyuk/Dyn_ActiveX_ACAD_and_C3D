namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentPILabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentPILabel _i;
		internal AeccAlignmentPILabel(object AeccAlignmentPILabel_object) 
		{
			this._i = AeccAlignmentPILabel_object as Autodesk.AECC.Interop.Land.IAeccAlignmentPILabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
