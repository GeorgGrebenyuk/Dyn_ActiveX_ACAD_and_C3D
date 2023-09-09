namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureSectionLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureSectionLabel _i;
		internal AeccStructureSectionLabel(object AeccStructureSectionLabel_object) 
		{
			this._i = AeccStructureSectionLabel_object as Autodesk.AECC.Interop.Pipe.IAeccStructureSectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
