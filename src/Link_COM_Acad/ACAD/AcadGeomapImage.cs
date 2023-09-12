namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGeomapImage 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadGeomapImage _i;
		internal AcadGeomapImage(object AcadGeomapImage_object) 
		{
			this._i = AcadGeomapImage_object as Autodesk.AutoCAD.Interop.Common.AcadGeomapImage;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public int GeoImageBrightness => this._i.GeoImageBrightness;

		///<summary>
		///
		///</summary>
		public void Set_GeoImageBrightness(int Brightness) 
		{
			this._i.GeoImageBrightness = Brightness;
		}

		///<summary>
		///
		///</summary>
		public int GeoImageContrast => this._i.GeoImageContrast;

		///<summary>
		///
		///</summary>
		public void Set_GeoImageContrast(int Contrast) 
		{
			this._i.GeoImageContrast = Contrast;
		}

		///<summary>
		///
		///</summary>
		public int GeoImageFade => this._i.GeoImageFade;

		///<summary>
		///
		///</summary>
		public void Set_GeoImageFade(int Fade) 
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
