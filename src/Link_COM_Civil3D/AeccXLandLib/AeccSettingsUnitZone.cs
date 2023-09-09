namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsUnitZone 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsUnitZone _i;
		internal AeccSettingsUnitZone(object AeccSettingsUnitZone_object) 
		{
			this._i = AeccSettingsUnitZone_object as Autodesk.AECC.Interop.Land.IAeccSettingsUnitZone;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DrawingUnits => this._i.DrawingUnits;

		///<summary>
		///
		///</summary>
		public void Set_DrawingUnits(Autodesk.AECC.Interop.Land.AeccDrawingUnitType pVal) 
		{
			this._i.DrawingUnits = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic FootToMeterConversionFlag => this._i.FootToMeterConversionFlag;

		///<summary>
		///
		///</summary>
		public void Set_FootToMeterConversionFlag(Autodesk.AECC.Interop.Land.AeccFootToMeterConversionFlag pVal) 
		{
			this._i.FootToMeterConversionFlag = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AngularUnits => this._i.AngularUnits;

		///<summary>
		///
		///</summary>
		public void Set_AngularUnits(Autodesk.AECC.Interop.Land.AeccAngleUnitType pVal) 
		{
			this._i.AngularUnits = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ScaleObjectsFromOtherDrawings => this._i.ScaleObjectsFromOtherDrawings;

		///<summary>
		///
		///</summary>
		public void Set_ScaleObjectsFromOtherDrawings(bool pVal) 
		{
			this._i.ScaleObjectsFromOtherDrawings = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DrawingScale => this._i.DrawingScale;

		///<summary>
		///
		///</summary>
		public void Set_DrawingScale(double pVal) 
		{
			this._i.DrawingScale = pVal;
		}

		///<summary>
		///
		///</summary>
		private void HiddenField_SetAutoCADVariablesToMatch() 
		{
			
		}

		///<summary>
		///
		///</summary>
		public bool MatchAutoCADVariables => this._i.MatchAutoCADVariables;

		///<summary>
		///
		///</summary>
		public void Set_MatchAutoCADVariables(bool pVal) 
		{
			this._i.MatchAutoCADVariables = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CoordinateSystem => this._i.CoordinateSystem;
	}
}
