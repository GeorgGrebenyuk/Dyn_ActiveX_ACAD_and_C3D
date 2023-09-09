namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccConnector 
	{
		public AeccXPipeLib.IAeccConnector _i;
		internal AeccConnector(object AeccConnector_object) 
		{
			this._i = AeccConnector_object as AeccXPipeLib.IAeccConnector;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NetworkPart => this._i.NetworkPart;
	}
}
