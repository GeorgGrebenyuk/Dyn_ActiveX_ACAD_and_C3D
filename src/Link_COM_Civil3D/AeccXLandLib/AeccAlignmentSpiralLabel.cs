namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSpiralLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSpiralLabel _i;
		internal AeccAlignmentSpiralLabel(object AeccAlignmentSpiralLabel_object) 
		{
			this._i = AeccAlignmentSpiralLabel_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSpiralLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
