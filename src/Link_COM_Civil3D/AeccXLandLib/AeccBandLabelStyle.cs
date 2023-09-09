namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandLabelStyle 
	{
		public AeccXLandLib.IAeccBandLabelStyle _i;
		internal AeccBandLabelStyle(object AeccBandLabelStyle_object) 
		{
			this._i = AeccBandLabelStyle_object as AeccXLandLib.IAeccBandLabelStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic TickStyle => this._i.TickStyle;

		///<summary>
		///
		///</summary>
		public dynamic TextComponents => this._i.TextComponents;

		///<summary>
		///
		///</summary>
		public dynamic LineComponents => this._i.LineComponents;

		///<summary>
		///
		///</summary>
		public dynamic BlockComponents => this._i.BlockComponents;
	}
}
