namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsQuantityTakeoff 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsQuantityTakeoff _i;
		internal AeccSettingsCommandsQuantityTakeoff(object AeccSettingsCommandsQuantityTakeoff_object) 
		{
			this._i = AeccSettingsCommandsQuantityTakeoff_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsQuantityTakeoff;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddMaterialVolumeTable => this._i.AddMaterialVolumeTable;

		///<summary>
		///
		///</summary>
		public dynamic AddTotalVolumeTable => this._i.AddTotalVolumeTable;

		///<summary>
		///
		///</summary>
		public dynamic ComputeMaterials => this._i.ComputeMaterials;

		///<summary>
		///
		///</summary>
		public dynamic GenerateQuantitiesReport => this._i.GenerateQuantitiesReport;

		///<summary>
		///
		///</summary>
		public dynamic AssignPayItemToArea => this._i.AssignPayItemToArea;

		///<summary>
		///
		///</summary>
		public dynamic TakeOff => this._i.TakeOff;
	}
}
