namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandTickStyle 
	{
		public AeccXLandLib.IAeccBandTickStyle _i;
		internal AeccBandTickStyle(object AeccBandTickStyle_object) 
		{
			this._i = AeccBandTickStyle_object as AeccXLandLib.IAeccBandTickStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_IncrementTicksToFullHeight(bool pVal) 
		{
			this._i.IncrementTicksToFullHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IncrementTicksToFullHeight => this._i.IncrementTicksToFullHeight;

		///<summary>
		///
		///</summary>
		public void Set_IncrementSmallTicksAtTop(bool pVal) 
		{
			this._i.IncrementSmallTicksAtTop = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IncrementSmallTicksAtTop => this._i.IncrementSmallTicksAtTop;

		///<summary>
		///
		///</summary>
		public void Set_IncrementSmallTicksAtMiddle(bool pVal) 
		{
			this._i.IncrementSmallTicksAtMiddle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IncrementSmallTicksAtMiddle => this._i.IncrementSmallTicksAtMiddle;

		///<summary>
		///
		///</summary>
		public void Set_IncrementSmallTicksAtBottom(bool pVal) 
		{
			this._i.IncrementSmallTicksAtBottom = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IncrementSmallTicksAtBottom => this._i.IncrementSmallTicksAtBottom;

		///<summary>
		///
		///</summary>
		public void Set_SmallTicksAtTopSize(double pVal) 
		{
			this._i.SmallTicksAtTopSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SmallTicksAtTopSize => this._i.SmallTicksAtTopSize;

		///<summary>
		///
		///</summary>
		public void Set_SmallTicksAtMiddleSize(double pVal) 
		{
			this._i.SmallTicksAtMiddleSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SmallTicksAtMiddleSize => this._i.SmallTicksAtMiddleSize;

		///<summary>
		///
		///</summary>
		public void Set_SmallTicksAtBottomSize(double pVal) 
		{
			this._i.SmallTicksAtBottomSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SmallTicksAtBottomSize => this._i.SmallTicksAtBottomSize;
	}
}
