namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionPipeNetwork 
	{
		public AeccXPipeLib.IAeccSectionPipeNetwork _i;
		internal AeccSectionPipeNetwork(object AeccSectionPipeNetwork_object) 
		{
			this._i = AeccSectionPipeNetwork_object as AeccXPipeLib.IAeccSectionPipeNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
