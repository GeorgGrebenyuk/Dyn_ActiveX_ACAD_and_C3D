namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMultiProfileViewCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMultiProfileViewCreation _i;
		internal AeccSettingsMultiProfileViewCreation(object AeccSettingsMultiProfileViewCreation_object) 
		{
			this._i = AeccSettingsMultiProfileViewCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsMultiProfileViewCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultLength => this._i.DefaultLength;

		///<summary>
		///
		///</summary>
		public dynamic DefaultHeight => this._i.DefaultHeight;

		///<summary>
		///
		///</summary>
		public dynamic DatumBy => this._i.DatumBy;

		///<summary>
		///
		///</summary>
		public dynamic PlotPattern => this._i.PlotPattern;

		///<summary>
		///
		///</summary>
		public dynamic ViewsInRowOrColumn => this._i.ViewsInRowOrColumn;

		///<summary>
		///
		///</summary>
		public dynamic StartCorner => this._i.StartCorner;

		///<summary>
		///
		///</summary>
		public dynamic ColumnSpacing => this._i.ColumnSpacing;

		///<summary>
		///
		///</summary>
		public dynamic RowSpacing => this._i.RowSpacing;
	}
}
