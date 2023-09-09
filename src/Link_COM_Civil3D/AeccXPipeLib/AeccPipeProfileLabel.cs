namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeProfileLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeProfileLabel _i;
		internal AeccPipeProfileLabel(object AeccPipeProfileLabel_object) 
		{
			this._i = AeccPipeProfileLabel_object as Autodesk.AECC.Interop.Pipe.IAeccPipeProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
