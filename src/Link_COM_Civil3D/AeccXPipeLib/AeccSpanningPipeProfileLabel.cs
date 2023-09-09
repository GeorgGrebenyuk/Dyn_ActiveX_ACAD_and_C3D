namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSpanningPipeProfileLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSpanningPipeProfileLabel _i;
		internal AeccSpanningPipeProfileLabel(object AeccSpanningPipeProfileLabel_object) 
		{
			this._i = AeccSpanningPipeProfileLabel_object as Autodesk.AECC.Interop.Pipe.IAeccSpanningPipeProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
