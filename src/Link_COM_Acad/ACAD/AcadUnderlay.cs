namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadUnderlay 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadUnderlay _i;
		internal AcadUnderlay(object AcadUnderlay_object) 
		{
			this._i = AcadUnderlay_object as Autodesk.AutoCAD.Interop.Common.IAcadUnderlay;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public int Contrast => this._i.Contrast;

		///<summary>
		///
		///</summary>
		public void Set_Contrast(int Contrast) 
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
		public object Position => this._i.Position;

		///<summary>
		///
		///</summary>
		public void Set_Position(object pos) 
		{
			this._i.Position = pos;
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
		public string UnderlayName => this._i.UnderlayName;

		///<summary>
		///
		///</summary>
		public void Set_UnderlayName(string Name) 
		{
			this._i.UnderlayName = Name;
		}

		///<summary>
		///
		///</summary>
		public void Set_ItemName(string sheetName) 
		{
			this._i.ItemName = sheetName;
		}

		///<summary>
		///
		///</summary>
		public string ItemName => this._i.ItemName;

		///<summary>
		///
		///</summary>
		public bool Monochrome => this._i.Monochrome;

		///<summary>
		///
		///</summary>
		public void Set_Monochrome(bool bMono) 
		{
			this._i.Monochrome = bMono;
		}

		///<summary>
		///
		///</summary>
		public bool AdjustForBackground => this._i.AdjustForBackground;

		///<summary>
		///
		///</summary>
		public void Set_AdjustForBackground(bool Value) 
		{
			this._i.AdjustForBackground = Value;
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
		public dynamic ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(dynamic ScaleFactor) 
		{
			this._i.ScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public string File => this._i.File;

		///<summary>
		///
		///</summary>
		public void Set_File(string Name) 
		{
			this._i.File = Name;
		}

		///<summary>
		///
		///</summary>
		public bool UnderlayVisibility => this._i.UnderlayVisibility;

		///<summary>
		///
		///</summary>
		public void Set_UnderlayVisibility(bool fVisible) 
		{
			this._i.UnderlayVisibility = fVisible;
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
		public dynamic UnderlayLayerOverrideApplied => this._i.UnderlayLayerOverrideApplied;

		///<summary>
		///
		///</summary>
		public void Set_UnderlayLayerOverrideApplied(Autodesk.AutoCAD.Interop.Common.AcUnderlayLayerOverrideType bOverride) 
		{
			this._i.UnderlayLayerOverrideApplied = bOverride;
		}
	}
}
