namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAssignPayItemToArea 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsAssignPayItemToArea _i;
		internal AeccSettingsAssignPayItemToArea(object AeccSettingsAssignPayItemToArea_object) 
		{
			this._i = AeccSettingsAssignPayItemToArea_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsAssignPayItemToArea;
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
