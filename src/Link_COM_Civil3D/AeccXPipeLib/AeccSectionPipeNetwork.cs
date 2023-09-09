namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionPipeNetwork 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSectionPipeNetwork _i;
		internal AeccSectionPipeNetwork(object AeccSectionPipeNetwork_object) 
		{
			this._i = AeccSectionPipeNetwork_object as Autodesk.AECC.Interop.Pipe.IAeccSectionPipeNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
