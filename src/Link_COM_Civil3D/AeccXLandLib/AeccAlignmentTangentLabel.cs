namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentTangentLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentTangentLabel _i;
		internal AeccAlignmentTangentLabel(object AeccAlignmentTangentLabel_object) 
		{
			this._i = AeccAlignmentTangentLabel_object as Autodesk.AECC.Interop.Land.IAeccAlignmentTangentLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;
	}
}
