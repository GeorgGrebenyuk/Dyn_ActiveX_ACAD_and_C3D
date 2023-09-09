namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureSectionLabel 
	{
		public AeccXPipeLib.IAeccStructureSectionLabel _i;
		internal AeccStructureSectionLabel(object AeccStructureSectionLabel_object) 
		{
			this._i = AeccStructureSectionLabel_object as AeccXPipeLib.IAeccStructureSectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
