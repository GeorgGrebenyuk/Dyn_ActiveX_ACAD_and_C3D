namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeSectionLabel 
	{
		public AeccXPipeLib.IAeccPipeSectionLabel _i;
		internal AeccPipeSectionLabel(object AeccPipeSectionLabel_object) 
		{
			this._i = AeccPipeSectionLabel_object as AeccXPipeLib.IAeccPipeSectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
