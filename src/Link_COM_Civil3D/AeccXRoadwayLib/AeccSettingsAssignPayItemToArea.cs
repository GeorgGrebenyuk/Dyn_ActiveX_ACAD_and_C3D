namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAssignPayItemToArea 
	{
		public AeccXRoadwayLib.IAeccSettingsAssignPayItemToArea _i;
		internal AeccSettingsAssignPayItemToArea(object AeccSettingsAssignPayItemToArea_object) 
		{
			this._i = AeccSettingsAssignPayItemToArea_object as AeccXRoadwayLib.IAeccSettingsAssignPayItemToArea;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UseAutoCADColorAndLayer => this._i.UseAutoCADColorAndLayer;

		///<summary>
		///
		///</summary>
		public dynamic HatchLayer => this._i.HatchLayer;

		///<summary>
		///
		///</summary>
		public dynamic HatchColor => this._i.HatchColor;
	}
}
