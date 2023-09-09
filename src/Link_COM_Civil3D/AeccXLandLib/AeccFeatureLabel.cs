namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLabel 
	{
		public AeccXLandLib.IAeccFeatureLabel _i;
		internal AeccFeatureLabel(object AeccFeatureLabel_object) 
		{
			this._i = AeccFeatureLabel_object as AeccXLandLib.IAeccFeatureLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;
	}
}
