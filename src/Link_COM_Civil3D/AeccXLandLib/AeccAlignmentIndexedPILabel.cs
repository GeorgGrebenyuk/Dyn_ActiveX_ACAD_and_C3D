namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentIndexedPILabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentIndexedPILabel _i;
		internal AeccAlignmentIndexedPILabel(object AeccAlignmentIndexedPILabel_object) 
		{
			this._i = AeccAlignmentIndexedPILabel_object as Autodesk.AECC.Interop.Land.IAeccAlignmentIndexedPILabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
