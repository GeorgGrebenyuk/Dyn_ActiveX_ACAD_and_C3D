namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAssemblyStyles 
	{
		public AeccXRoadwayLib.IAeccSettingsAssemblyStyles _i;
		internal AeccSettingsAssemblyStyles(object AeccSettingsAssemblyStyles_object) 
		{
			this._i = AeccSettingsAssemblyStyles_object as AeccXRoadwayLib.IAeccSettingsAssemblyStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic CodeSetStyle => this._i.CodeSetStyle;
	}
}
