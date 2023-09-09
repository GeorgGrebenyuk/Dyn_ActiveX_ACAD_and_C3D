namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureLabel _i;
		internal AeccStructureLabel(object AeccStructureLabel_object) 
		{
			this._i = AeccStructureLabel_object as Autodesk.AECC.Interop.Pipe.IAeccStructureLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Structure => this._i.Structure;

		///<summary>
		///
		///</summary>
		public dynamic ReferenceAlignment => this._i.ReferenceAlignment;

		///<summary>
		///
		///</summary>
		public void Set_ReferenceAlignment(object ppVal) 
		{
			this._i.ReferenceAlignment = ppVal;
		}
	}
}
