namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGridSettings 
	{
		public AeccXRoadwayLib.IAeccSettingsGridSettings _i;
		internal AeccSettingsGridSettings(object AeccSettingsGridSettings_object) 
		{
			this._i = AeccSettingsGridSettings_object as AeccXRoadwayLib.IAeccSettingsGridSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayHorizGrid => this._i.DisplayHorizGrid;

		///<summary>
		///
		///</summary>
		public dynamic DisplayVertGrid => this._i.DisplayVertGrid;

		///<summary>
		///
		///</summary>
		public dynamic HorizGridInterval => this._i.HorizGridInterval;

		///<summary>
		///
		///</summary>
		public dynamic VertGridInterval => this._i.VertGridInterval;

		///<summary>
		///
		///</summary>
		public dynamic GridColor => this._i.GridColor;

		///<summary>
		///
		///</summary>
		public dynamic DisplayCenterAxis => this._i.DisplayCenterAxis;

		///<summary>
		///
		///</summary>
		public dynamic CenterAxisColor => this._i.CenterAxisColor;
	}
}
