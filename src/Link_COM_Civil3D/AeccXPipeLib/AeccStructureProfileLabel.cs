namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureProfileLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureProfileLabel _i;
		internal AeccStructureProfileLabel(object AeccStructureProfileLabel_object) 
		{
			this._i = AeccStructureProfileLabel_object as Autodesk.AECC.Interop.Pipe.IAeccStructureProfileLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
