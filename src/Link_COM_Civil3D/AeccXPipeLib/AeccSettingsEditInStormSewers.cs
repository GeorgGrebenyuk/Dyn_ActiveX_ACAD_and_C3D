namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsEditInStormSewers 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsEditInStormSewers _i;
		internal AeccSettingsEditInStormSewers(object AeccSettingsEditInStormSewers_object) 
		{
			this._i = AeccSettingsEditInStormSewers_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsEditInStormSewers;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
