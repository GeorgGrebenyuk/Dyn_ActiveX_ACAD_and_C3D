﻿namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRasterImage 
	{
		public AXDBLib.IAcadRasterImage _i;
		internal AcadRasterImage(object AcadRasterImage_object) 
		{
			this._i = AcadRasterImage_object as AXDBLib.IAcadRasterImage;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Brightness => this._i.Brightness;

		///<summary>
		///
		///</summary>
		public void Set_Brightness(dynamic Brightness) 
		{
			this._i.Brightness = Brightness;
		}

		///<summary>
		///
		///</summary>
		public dynamic Contrast => this._i.Contrast;

		///<summary>
		///
		///</summary>
		public void Set_Contrast(dynamic Contrast) 
		{
			this._i.Contrast = Contrast;
		}

		///<summary>
		///
		///</summary>
		public dynamic Fade => this._i.Fade;

		///<summary>
		///
		///</summary>
		public void Set_Fade(dynamic Fade) 
		{
			this._i.Fade = Fade;
		}

		///<summary>
		///
		///</summary>
		public object Origin => this._i.Origin;

		///<summary>
		///
		///</summary>
		public void Set_Origin(object Origin) 
		{
			this._i.Origin = Origin;
		}

		///<summary>
		///
		///</summary>
		public dynamic Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(dynamic rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public double ImageWidth => this._i.ImageWidth;

		///<summary>
		///
		///</summary>
		public void Set_ImageWidth(double Width) 
		{
			this._i.ImageWidth = Width;
		}

		///<summary>
		///
		///</summary>
		public double ImageHeight => this._i.ImageHeight;

		///<summary>
		///
		///</summary>
		public void Set_ImageHeight(double Height) 
		{
			this._i.ImageHeight = Height;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string Name) 
		{
			this._i.Name = Name;
		}

		///<summary>
		///
		///</summary>
		public void Set_ImageFile(string imageFileName) 
		{
			this._i.ImageFile = imageFileName;
		}

		///<summary>
		///
		///</summary>
		public string ImageFile => this._i.ImageFile;

		///<summary>
		///
		///</summary>
		public bool ImageVisibility => this._i.ImageVisibility;

		///<summary>
		///
		///</summary>
		public void Set_ImageVisibility(bool fVisible) 
		{
			this._i.ImageVisibility = fVisible;
		}

		///<summary>
		///
		///</summary>
		public bool ClippingEnabled => this._i.ClippingEnabled;

		///<summary>
		///
		///</summary>
		public void Set_ClippingEnabled(bool kClip) 
		{
			this._i.ClippingEnabled = kClip;
		}

		///<summary>
		///
		///</summary>
		public bool transparency => this._i.transparency;

		///<summary>
		///
		///</summary>
		public void Set_transparency(bool bTransp) 
		{
			this._i.transparency = bTransp;
		}

		///<summary>
		///
		///</summary>
		public void ClipBoundary(object boundry) 
		{
			this._i.ClipBoundary(boundry);
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public bool ShowRotation => this._i.ShowRotation;

		///<summary>
		///
		///</summary>
		public void Set_ShowRotation(bool bShow) 
		{
			this._i.ShowRotation = bShow;
		}

		///<summary>
		///
		///</summary>
		public dynamic ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(dynamic ScaleFactor) 
		{
			this._i.ScaleFactor = ScaleFactor;
		}
	}
}
