namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileLayout 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileLayout _i;
		internal AeccSettingsCreateProfileLayout(object AeccSettingsCreateProfileLayout_object) 
		{
			this._i = AeccSettingsCreateProfileLayout_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveTessellationOptionSettings => this._i.CurveTessellationOptionSettings;

		///<summary>
		///
		///</summary>
		public dynamic RegressionGraphOptionSettings => this._i.RegressionGraphOptionSettings;
	}
}
