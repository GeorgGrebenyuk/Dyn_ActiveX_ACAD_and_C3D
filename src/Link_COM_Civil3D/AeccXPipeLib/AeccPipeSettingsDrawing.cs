namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeSettingsDrawing 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeSettingsDrawing _i;
		internal AeccPipeSettingsDrawing(object AeccPipeSettingsDrawing_object) 
		{
			this._i = AeccPipeSettingsDrawing_object as Autodesk.AECC.Interop.Pipe.IAeccPipeSettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
