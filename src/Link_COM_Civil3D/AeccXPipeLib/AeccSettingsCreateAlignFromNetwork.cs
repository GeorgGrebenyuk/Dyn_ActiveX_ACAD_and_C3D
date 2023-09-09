namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignFromNetwork 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateAlignFromNetwork _i;
		internal AeccSettingsCreateAlignFromNetwork(object AeccSettingsCreateAlignFromNetwork_object) 
		{
			this._i = AeccSettingsCreateAlignFromNetwork_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateAlignFromNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
