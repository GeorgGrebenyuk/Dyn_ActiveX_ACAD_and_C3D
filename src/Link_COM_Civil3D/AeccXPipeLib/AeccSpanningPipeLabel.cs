namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSpanningPipeLabel 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSpanningPipeLabel _i;
		internal AeccSpanningPipeLabel(object AeccSpanningPipeLabel_object) 
		{
			this._i = AeccSpanningPipeLabel_object as Autodesk.AECC.Interop.Pipe.IAeccSpanningPipeLabel;
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

		///<summary>
		///
		///</summary>
		public string Pipes => this._i.Pipes;

		///<summary>
		///
		///</summary>
		public string Structures => this._i.Structures;
	}
}
