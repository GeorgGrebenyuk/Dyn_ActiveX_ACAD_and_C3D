namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleComponentDefaults 
	{
		public AeccXLandLib.IAeccLabelStyleComponentDefaults _i;
		internal AeccLabelStyleComponentDefaults(object AeccLabelStyleComponentDefaults_object) 
		{
			this._i = AeccLabelStyleComponentDefaults_object as AeccXLandLib.IAeccLabelStyleComponentDefaults;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;

		///<summary>
		///
		///</summary>
		public dynamic Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public dynamic TextHeight => this._i.TextHeight;
	}
}
