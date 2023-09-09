namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateNetworkReference 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateNetworkReference _i;
		internal AeccSettingsCreateNetworkReference(object AeccSettingsCreateNetworkReference_object) 
		{
			this._i = AeccSettingsCreateNetworkReference_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateNetworkReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
