namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegmentElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelSegmentElement _i;
		internal AeccParcelSegmentElement(object AeccParcelSegmentElement_object) 
		{
			this._i = AeccParcelSegmentElement_object as Autodesk.AECC.Interop.Land.IAeccParcelSegmentElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double StartX => this._i.StartX;

		///<summary>
		///
		///</summary>
		public double StartY => this._i.StartY;

		///<summary>
		///
		///</summary>
		public double StartZ => this._i.StartZ;

		///<summary>
		///
		///</summary>
		public double EndX => this._i.EndX;

		///<summary>
		///
		///</summary>
		public double EndY => this._i.EndY;

		///<summary>
		///
		///</summary>
		public double EndZ => this._i.EndZ;

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public dynamic ParcelSegment => this._i.ParcelSegment;
	}
}
