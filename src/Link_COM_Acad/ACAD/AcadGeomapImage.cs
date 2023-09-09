namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGeomapImage 
	{
		public AXDBLib.IAcadGeomapImage _i;
		internal AcadGeomapImage(object AcadGeomapImage_object) 
		{
			this._i = AcadGeomapImage_object as AXDBLib.IAcadGeomapImage;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GeoImageBrightness => this._i.GeoImageBrightness;

		///<summary>
		///
		///</summary>
		public void Set_GeoImageBrightness(dynamic Brightness) 
		{
			this._i.GeoImageBrightness = Brightness;
		}

		///<summary>
		///
		///</summary>
		public dynamic GeoImageContrast => this._i.GeoImageContrast;

		///<summary>
		///
		///</summary>
		public void Set_GeoImageContrast(dynamic Contrast) 
		{
			this._i.GeoImageContrast = Contrast;
		}

		///<summary>
		///
		///</summary>
		public dynamic GeoImageFade => this._i.GeoImageFade;

		///<summary>
		///
		///</summary>
		public void Set_GeoImageFade(dynamic Fade) 
		{
			this._i.GeoImageFade = Fade;
		}

		///<summary>
		///
		///</summary>
		public object GeoImagePosition => this._i.GeoImagePosition;

		///<summary>
		///
		///</summary>
		public double GeoImageWidth => this._i.GeoImageWidth;

		///<summary>
		///
		///</summary>
		public double GeoImageHeight => this._i.GeoImageHeight;
	}
}
