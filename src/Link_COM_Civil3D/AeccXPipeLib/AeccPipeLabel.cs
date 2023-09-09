namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeLabel _i;
		internal AeccPipeLabel(object AeccPipeLabel_object) 
		{
			this._i = AeccPipeLabel_object as Autodesk.AECC.Interop.Pipe.IAeccPipeLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Pipe => this._i.Pipe;

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
