namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsShowSpanningPipes 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsShowSpanningPipes _i;
		internal AeccSettingsShowSpanningPipes(object AeccSettingsShowSpanningPipes_object) 
		{
			this._i = AeccSettingsShowSpanningPipes_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsShowSpanningPipes;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
