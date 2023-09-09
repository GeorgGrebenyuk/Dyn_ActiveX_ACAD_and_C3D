namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateViewFrames 
	{
		public AeccXLandLib.IAeccSettingsCreateViewFrames _i;
		internal AeccSettingsCreateViewFrames(object AeccSettingsCreateViewFrames_object) 
		{
			this._i = AeccSettingsCreateViewFrames_object as AeccXLandLib.IAeccSettingsCreateViewFrames;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;
	}
}
