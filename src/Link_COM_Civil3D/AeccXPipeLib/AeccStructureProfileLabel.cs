namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureProfileLabel 
	{
		public AeccXPipeLib.IAeccStructureProfileLabel _i;
		internal AeccStructureProfileLabel(object AeccStructureProfileLabel_object) 
		{
			this._i = AeccStructureProfileLabel_object as AeccXPipeLib.IAeccStructureProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
