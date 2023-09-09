namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSpanningPipeProfileLabel 
	{
		public AeccXPipeLib.IAeccSpanningPipeProfileLabel _i;
		internal AeccSpanningPipeProfileLabel(object AeccSpanningPipeProfileLabel_object) 
		{
			this._i = AeccSpanningPipeProfileLabel_object as AeccXPipeLib.IAeccSpanningPipeProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
