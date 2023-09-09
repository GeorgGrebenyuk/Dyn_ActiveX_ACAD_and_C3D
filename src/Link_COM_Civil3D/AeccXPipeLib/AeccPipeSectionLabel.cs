namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeSectionLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeSectionLabel _i;
		internal AeccPipeSectionLabel(object AeccPipeSectionLabel_object) 
		{
			this._i = AeccPipeSectionLabel_object as Autodesk.AECC.Interop.Pipe.IAeccPipeSectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
