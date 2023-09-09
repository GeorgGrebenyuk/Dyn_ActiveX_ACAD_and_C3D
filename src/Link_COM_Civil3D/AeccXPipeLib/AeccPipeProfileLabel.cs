namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeProfileLabel 
	{
		public AeccXPipeLib.IAeccPipeProfileLabel _i;
		internal AeccPipeProfileLabel(object AeccPipeProfileLabel_object) 
		{
			this._i = AeccPipeProfileLabel_object as AeccXPipeLib.IAeccPipeProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
