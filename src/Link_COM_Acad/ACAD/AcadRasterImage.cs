using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// A raster image consisting of a rectangular grid (or raster) of small squares or dots known as pixels
    ///</summary>
    public class AcadRasterImage 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadRasterImage _i;
		internal AcadRasterImage(object AcadRasterImage_object) 
		{
			this._i = AcadRasterImage_object as Autodesk.AutoCAD.Interop.Common.AcadRasterImage;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Creates a new raster image based on an existing image file
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="imageFileName">The full path and file name of the image</param>
        /// <param name="InsertionPoint">The 3D WCS coordinates in the drawing where the raster image will be created</param>
        /// <param name="ScaleFactor">The raster image scale factor. The default image scale factor is 1. The scale factor must be a positive number. You can set the scale of the image to the scale of the geometry created in the AutoCAD drawing</param>
        /// <param name="RotationAngle">The rotation angle in radians for the raster image</param>
        public AcadRasterImage (AcadBlock AcadBlock, string imageFileName, Autodesk.DesignScript.Geometry.Point InsertionPoint, double ScaleFactor, double RotationAngle)
        {
            this._i = AcadBlock._i.AddRaster(imageFileName, Technical.PointByDynPoint(InsertionPoint), ScaleFactor, RotationAngle);
        }
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadRasterImage(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadRasterImage;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        ///Specifies the current brightness value of an image
        ///</summary>
        public int Brightness => this._i.Brightness;

        ///<summary>
        ///Specifies the current brightness value of an image
        ///</summary>
        public void Set_Brightness(int Brightness) 
		{
			this._i.Brightness = Brightness;
		}

        ///<summary>
        ///Specifies the current contrast value of an image or underlay
        ///</summary>
        public int Contrast => this._i.Contrast;

        ///<summary>
        ///Specifies the current contrast value of an image or underlay
        ///</summary>
        public void Set_Contrast(int Contrast) 
		{
			this._i.Contrast = Contrast;
		}

        ///<summary>
        ///Specifies the current fade value of a raster or underlay image
        ///</summary>
        public int Fade => this._i.Fade;

        ///<summary>
        ///Specifies the current fade value of a raster or underlay image
        ///</summary>
        public void Set_Fade(int Fade) 
		{
			this._i.Fade = Fade;
		}

        ///<summary>
        ///Specifies the origin of raster image in WCS coordinates
        ///</summary>
        public Point Origin => Technical.PointByDoubleArray(this._i.Origin);

        ///<summary>
        ///Specifies the origin of raster image in WCS coordinates
        ///</summary>
        public void Set_Origin(Point Origin) 
		{
			this._i.Origin = Technical.PointByDynPoint(Origin);
		}

		///<summary>
		///
		///</summary>
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

        ///<summary>
        ///Specifies the width of the raster image
        ///</summary>
        public double ImageWidth => this._i.ImageWidth;

        ///<summary>
        ///Specifies the width of the raster image
        ///</summary>
        public void Set_ImageWidth(double Width) 
		{
			this._i.ImageWidth = Width;
		}

        ///<summary>
        ///Specifies the height of the raster image
        ///</summary>
        public double ImageHeight => this._i.ImageHeight;

        ///<summary>
        ///Specifies the height of the raster image
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
        ///Specifies the full path and file name of the raster image file
        ///</summary>
        public void Set_ImageFile(string imageFileName) 
		{
			this._i.ImageFile = imageFileName;
		}

        ///<summary>
        ///Specifies the full path and file name of the raster image file
        ///</summary>
        public string ImageFile => this._i.ImageFile;

        ///<summary>
        ///Specifies whether image visibility is on or off
        ///</summary>
        public bool ImageVisibility => this._i.ImageVisibility;

        ///<summary>
        ///Specifies whether image visibility is on or off
        ///</summary>
        public void Set_ImageVisibility(bool fVisible) 
		{
			this._i.ImageVisibility = fVisible;
		}

        ///<summary>
        ///Enables or disables the clipping boundary
        ///</summary>
        public bool ClippingEnabled => this._i.ClippingEnabled;

        ///<summary>
        ///Enables or disables the clipping boundary
        ///</summary>
        public void Set_ClippingEnabled(bool kClip) 
		{
			this._i.ClippingEnabled = kClip;
		}

        ///<summary>
        ///Specifies if the transparency for a particular bitonal image is on or off
        ///</summary>
        public bool transparency => this._i.transparency;

        ///<summary>
        ///Specifies if the transparency for a particular bitonal image is on or off
        ///</summary>
        public void Set_transparency(bool bTransp) 
		{
			this._i.transparency = bTransp;
		}

        /// <summary>
        /// Specifies the clipping boundary for a raster image or an underlay
        /// </summary>
        /// <param name="boundry">An array of 2D WCS coordinates specifying the clipping boundary of a raster image or underlay</param>
        public void ClipBoundary(List<Point> boundry) 
		{
			this._i.ClipBoundary(Technical.PointsByDynPoints(boundry, true));
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
        /// Determines if a geomap image, raster image, or wipeout is displayed at its rotation value
        ///</summary>
        public bool ShowRotation => this._i.ShowRotation;

        ///<summary>
        /// Determines if a geomap image, raster image, or wipeout is displayed at its rotation value
        ///</summary>
        public void Set_ShowRotation(bool bShow) 
		{
			this._i.ShowRotation = bShow;
		}

        ///<summary>
        /// Specifies the scale factor for the object
        ///</summary>
        public double ScaleFactor => this._i.ScaleFactor;

        ///<summary>
        /// Specifies the scale factor for the object
        ///</summary>
        public void Set_ScaleFactor(double ScaleFactor) 
		{
			this._i.ScaleFactor = ScaleFactor;
		}
	}
}
