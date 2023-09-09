namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyle _i;
		internal AeccLabelStyle(object AeccLabelStyle_object) 
		{
			this._i = AeccLabelStyle_object as Autodesk.AECC.Interop.Land.IAeccLabelStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic DraggedComponentStyle => this._i.DraggedComponentStyle;

		///<summary>
		///
		///</summary>
		public dynamic DraggedLeaderStyle => this._i.DraggedLeaderStyle;

		///<summary>
		///
		///</summary>
		public dynamic TextComponents => this._i.TextComponents;

		///<summary>
		///
		///</summary>
		public dynamic LineComponents => this._i.LineComponents;

		///<summary>
		///
		///</summary>
		public dynamic TickComponents => this._i.TickComponents;

		///<summary>
		///
		///</summary>
		public dynamic BlockComponents => this._i.BlockComponents;

		///<summary>
		///
		///</summary>
		public dynamic DirectionArrowComponents => this._i.DirectionArrowComponents;

		///<summary>
		///
		///</summary>
		public dynamic Children => this._i.Children;

		///<summary>
		///
		///</summary>
		public dynamic Descendants => this._i.Descendants;

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///
		///</summary>
		private void HiddenField_Init(Autodesk.AECC.Interop.Land.AeccLabelStyleType newVal) 
		{
			
		}

		///<summary>
		///
		///</summary>
		public void RemoveOverrides() 
		{
			this._i.RemoveOverrides();
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelProperties => this._i.LabelProperties;
	}
}
