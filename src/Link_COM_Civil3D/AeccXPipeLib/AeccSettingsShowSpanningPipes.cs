namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsShowSpanningPipes 
	{
		public AeccXPipeLib.IAeccSettingsShowSpanningPipes _i;
		internal AeccSettingsShowSpanningPipes(object AeccSettingsShowSpanningPipes_object) 
		{
			this._i = AeccSettingsShowSpanningPipes_object as AeccXPipeLib.IAeccSettingsShowSpanningPipes;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
