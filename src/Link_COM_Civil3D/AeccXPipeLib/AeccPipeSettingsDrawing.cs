namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeSettingsDrawing 
	{
		public AeccXPipeLib.IAeccPipeSettingsDrawing _i;
		internal AeccPipeSettingsDrawing(object AeccPipeSettingsDrawing_object) 
		{
			this._i = AeccPipeSettingsDrawing_object as AeccXPipeLib.IAeccPipeSettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
