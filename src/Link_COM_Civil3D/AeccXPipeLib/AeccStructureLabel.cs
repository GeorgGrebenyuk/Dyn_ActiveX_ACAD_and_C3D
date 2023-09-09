namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureLabel 
	{
		public AeccXPipeLib.IAeccStructureLabel _i;
		internal AeccStructureLabel(object AeccStructureLabel_object) 
		{
			this._i = AeccStructureLabel_object as AeccXPipeLib.IAeccStructureLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Structure => this._i.Structure;

		///<summary>
		///
		///</summary>
		public dynamic ReferenceAlignment => this._i.ReferenceAlignment;

		///<summary>
		///
		///</summary>
		public void Set_ReferenceAlignment(object ppVal) 
		{
			this._i.ReferenceAlignment = ppVal;
		}
	}
}
