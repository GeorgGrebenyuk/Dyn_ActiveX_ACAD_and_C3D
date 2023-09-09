namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileViewStacked 
	{
		public AeccXLandLib.IAeccSettingsProfileViewStacked _i;
		internal AeccSettingsProfileViewStacked(object AeccSettingsProfileViewStacked_object) 
		{
			this._i = AeccSettingsProfileViewStacked_object as AeccXLandLib.IAeccSettingsProfileViewStacked;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StackedViews => this._i.StackedViews;

		///<summary>
		///
		///</summary>
		public dynamic NumOfStackedViews => this._i.NumOfStackedViews;

		///<summary>
		///
		///</summary>
		public dynamic GapBetweenViews => this._i.GapBetweenViews;
	}
}
