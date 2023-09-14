﻿using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadOle 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadOle _i;
		internal AcadOle(object AcadOle_object) 
		{
			this._i = AcadOle_object as Autodesk.AutoCAD.Interop.Common.AcadOle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadOle(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadOle;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///
        ///</summary>
        public Point InsertionPoint => Technical.PointByDynPoint(this._i.InsertionPoint);

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(Point insPoint) 
		{
			this._i.InsertionPoint = Technical.PointByDynPoint(insPoint);
		}

		///<summary>
		///
		///</summary>
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double Rotation) 
		{
			this._i.Rotation = Rotation;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double Width) 
		{
			this._i.Width = Width;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

		///<summary>
		///
		///</summary>
		public double ScaleWidth => this._i.ScaleWidth;

		///<summary>
		///
		///</summary>
		public void Set_ScaleWidth(double swidth) 
		{
			this._i.ScaleWidth = swidth;
		}

		///<summary>
		///
		///</summary>
		public double ScaleHeight => this._i.ScaleHeight;

		///<summary>
		///
		///</summary>
		public void Set_ScaleHeight(double sheight) 
		{
			this._i.ScaleHeight = sheight;
		}

		///<summary>
		///
		///</summary>
		public bool LockAspectRatio => this._i.LockAspectRatio;

		///<summary>
		///
		///</summary>
		public void Set_LockAspectRatio(bool aspect) 
		{
			this._i.LockAspectRatio = aspect;
		}

		///<summary>
		///
		///</summary>
		public object OleItemType => this._i.OleItemType;

		///<summary>
		///
		///</summary>
		public void Set_OleItemType(Autodesk.AutoCAD.Interop.Common.AcOleType pType) 
		{
			this._i.OleItemType = pType;
		}

		///<summary>
		///
		///</summary>
		public object OlePlotQuality => this._i.OlePlotQuality;

		///<summary>
		///
		///</summary>
		public void Set_OlePlotQuality(Autodesk.AutoCAD.Interop.Common.AcOlePlotQuality pPQuality) 
		{
			this._i.OlePlotQuality = pPQuality;
		}

		///<summary>
		///
		///</summary>
		public string OleSourceApp => this._i.OleSourceApp;

		///<summary>
		///
		///</summary>
		public void Set_OleSourceApp(string srcApp) 
		{
			this._i.OleSourceApp = srcApp;
		}
	}
}