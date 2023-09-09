namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterferenceStyle 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccInterferenceStyle _i;
		internal AeccInterferenceStyle(object AeccInterferenceStyle_object) 
		{
			this._i = AeccInterferenceStyle_object as Autodesk.AECC.Interop.Pipe.IAeccInterferenceStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PlanSymbolDisplayStyle2D => this._i.PlanSymbolDisplayStyle2D;

		///<summary>
		///
		///</summary>
		public dynamic PlanSymbolDisplayStyle3D => this._i.PlanSymbolDisplayStyle3D;

		///<summary>
		///
		///</summary>
		public dynamic ModelSolidDisplayStyle2D => this._i.ModelSolidDisplayStyle2D;

		///<summary>
		///
		///</summary>
		public dynamic ModelSolidDisplayStyle3D => this._i.ModelSolidDisplayStyle3D;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyle => this._i.MarkerStyle;

		///<summary>
		///
		///</summary>
		public void Put_MarkerStyle(dynamic ppiStyle) 
		{
			this._i.MarkerStyle = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic ModelOptions => this._i.ModelOptions;

		///<summary>
		///
		///</summary>
		public void Set_ModelOptions(Autodesk.AECC.Interop.Pipe.AeccInterferenceModelOptions pModelOptions) 
		{
			this._i.ModelOptions = pModelOptions;
		}

		///<summary>
		///
		///</summary>
		public dynamic InterferenceSizeType => this._i.InterferenceSizeType;

		///<summary>
		///
		///</summary>
		public void Set_InterferenceSizeType(Autodesk.AECC.Interop.Pipe.AeccInterferenceSizeType pInterferenceSizeType) 
		{
			this._i.InterferenceSizeType = pInterferenceSizeType;
		}

		///<summary>
		///
		///</summary>
		public dynamic ModelSizeOptions => this._i.ModelSizeOptions;

		///<summary>
		///
		///</summary>
		public void Set_ModelSizeOptions(Autodesk.AECC.Interop.Pipe.AeccInterferenceModelSizeOptions pModelSizeOptions) 
		{
			this._i.ModelSizeOptions = pModelSizeOptions;
		}

		///<summary>
		///
		///</summary>
		public double AbsoluteModelSize => this._i.AbsoluteModelSize;

		///<summary>
		///
		///</summary>
		public void Set_AbsoluteModelSize(double pdVal) 
		{
			this._i.AbsoluteModelSize = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double DrawingScaleModelSize => this._i.DrawingScaleModelSize;

		///<summary>
		///
		///</summary>
		public void Set_DrawingScaleModelSize(double pdVal) 
		{
			this._i.DrawingScaleModelSize = pdVal;
		}
	}
}
