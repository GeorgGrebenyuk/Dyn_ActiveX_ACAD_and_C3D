namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStylePlanOptionBase 
	{
		public AeccXPipeLib.IAeccPipeStylePlanOptionBase _i;
		internal AeccPipeStylePlanOptionBase(object AeccPipeStylePlanOptionBase_object) 
		{
			this._i = AeccPipeStylePlanOptionBase_object as AeccXPipeLib.IAeccPipeStylePlanOptionBase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double InnerDiameter => this._i.InnerDiameter;

		///<summary>
		///
		///</summary>
		public void Set_InnerDiameter(double pdVal) 
		{
			this._i.InnerDiameter = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double InnerDiameterPercent => this._i.InnerDiameterPercent;

		///<summary>
		///
		///</summary>
		public void Set_InnerDiameterPercent(double pdVal) 
		{
			this._i.InnerDiameterPercent = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double OuterDiameter => this._i.OuterDiameter;

		///<summary>
		///
		///</summary>
		public void Set_OuterDiameter(double pdVal) 
		{
			this._i.OuterDiameter = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double OuterDiameterPercent => this._i.OuterDiameterPercent;

		///<summary>
		///
		///</summary>
		public void Set_OuterDiameterPercent(double pdVal) 
		{
			this._i.OuterDiameterPercent = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double EndLineSize => this._i.EndLineSize;

		///<summary>
		///
		///</summary>
		public void Set_EndLineSize(double pdVal) 
		{
			this._i.EndLineSize = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double EndLineSizePercent => this._i.EndLineSizePercent;

		///<summary>
		///
		///</summary>
		public void Set_EndLineSizePercent(double pdVal) 
		{
			this._i.EndLineSizePercent = pdVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchOptions => this._i.HatchOptions;

		///<summary>
		///
		///</summary>
		public void Set_HatchOptions(AeccXPipeLib.AeccPipeHatchOptions pnHatchOptions) 
		{
			this._i.HatchOptions = pnHatchOptions;
		}

		///<summary>
		///
		///</summary>
		public dynamic WallSizeType => this._i.WallSizeType;

		///<summary>
		///
		///</summary>
		public void Set_WallSizeType(AeccXPipeLib.AeccPipeWallSizeType pnWallSizeType) 
		{
			this._i.WallSizeType = pnWallSizeType;
		}

		///<summary>
		///
		///</summary>
		public dynamic EndSizeType => this._i.EndSizeType;

		///<summary>
		///
		///</summary>
		public void Set_EndSizeType(AeccXPipeLib.AeccPipeEndSizeType pnEndSizeType) 
		{
			this._i.EndSizeType = pnEndSizeType;
		}

		///<summary>
		///
		///</summary>
		public dynamic WallSizeOptions => this._i.WallSizeOptions;

		///<summary>
		///
		///</summary>
		public void Set_WallSizeOptions(AeccXPipeLib.AeccPipeDisplayOptions pnWallSizeOptions) 
		{
			this._i.WallSizeOptions = pnWallSizeOptions;
		}

		///<summary>
		///
		///</summary>
		public dynamic EndSizeOptions => this._i.EndSizeOptions;

		///<summary>
		///
		///</summary>
		public void Set_EndSizeOptions(AeccXPipeLib.AeccPipeDisplayOptions pnEndSizeOptions) 
		{
			this._i.EndSizeOptions = pnEndSizeOptions;
		}
	}
}
