namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateNetworkFromObject 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateNetworkFromObject _i;
		internal AeccSettingsCreateNetworkFromObject(object AeccSettingsCreateNetworkFromObject_object) 
		{
			this._i = AeccSettingsCreateNetworkFromObject_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateNetworkFromObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
