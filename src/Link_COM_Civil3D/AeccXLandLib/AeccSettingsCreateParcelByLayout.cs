namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateParcelByLayout 
	{
		public AeccXLandLib.IAeccSettingsCreateParcelByLayout _i;
		internal AeccSettingsCreateParcelByLayout(object AeccSettingsCreateParcelByLayout_object) 
		{
			this._i = AeccSettingsCreateParcelByLayout_object as AeccXLandLib.IAeccSettingsCreateParcelByLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultArea => this._i.DefaultArea;

		///<summary>
		///
		///</summary>
		public dynamic MinimumFrontage => this._i.MinimumFrontage;

		///<summary>
		///
		///</summary>
		public dynamic EnableAutosnap => this._i.EnableAutosnap;

		///<summary>
		///
		///</summary>
		public dynamic SnapIncrement => this._i.SnapIncrement;

		///<summary>
		///
		///</summary>
		public dynamic AutoAddSegmentLabels => this._i.AutoAddSegmentLabels;

		///<summary>
		///
		///</summary>
		public dynamic AutomaticMode => this._i.AutomaticMode;

		///<summary>
		///
		///</summary>
		public dynamic RemainderDistribution => this._i.RemainderDistribution;
	}
}
