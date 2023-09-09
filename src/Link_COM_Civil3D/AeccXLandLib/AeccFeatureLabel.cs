namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccFeatureLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccFeatureLabel _i;
		internal AeccFeatureLabel(object AeccFeatureLabel_object) 
		{
			this._i = AeccFeatureLabel_object as Autodesk.AECC.Interop.Land.IAeccFeatureLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;
	}
}
