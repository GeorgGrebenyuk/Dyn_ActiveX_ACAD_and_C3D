namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsEditInStormSewers 
	{
		public AeccXPipeLib.IAeccSettingsEditInStormSewers _i;
		internal AeccSettingsEditInStormSewers(object AeccSettingsEditInStormSewers_object) 
		{
			this._i = AeccSettingsEditInStormSewers_object as AeccXPipeLib.IAeccSettingsEditInStormSewers;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
