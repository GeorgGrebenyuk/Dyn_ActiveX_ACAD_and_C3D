namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelDraggedComponentStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelDraggedComponentStyle _i;
		internal AeccLabelDraggedComponentStyle(object AeccLabelDraggedComponentStyle_object) 
		{
			this._i = AeccLabelDraggedComponentStyle_object as Autodesk.AECC.Interop.Land.IAeccLabelDraggedComponentStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayBorder => this._i.DisplayBorder;

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public dynamic Gap => this._i.Gap;

		///<summary>
		///
		///</summary>
		public dynamic Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public dynamic StackText => this._i.StackText;

		///<summary>
		///
		///</summary>
		public dynamic TextHeight => this._i.TextHeight;

		///<summary>
		///
		///</summary>
		public dynamic LeaderJustification => this._i.LeaderJustification;

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;

		///<summary>
		///
		///</summary>
		public dynamic LeaderAttachment => this._i.LeaderAttachment;

		///<summary>
		///
		///</summary>
		public dynamic BorderType => this._i.BorderType;
	}
}
