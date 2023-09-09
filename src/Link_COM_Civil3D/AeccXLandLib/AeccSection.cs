namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSection 
	{
		public Autodesk.AECC.Interop.Land.IAeccSection _i;
		internal AeccSection(object AeccSection_object) 
		{
			this._i = AeccSection_object as Autodesk.AECC.Interop.Land.IAeccSection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public double ElevationMin => this._i.ElevationMin;

		///<summary>
		///
		///</summary>
		public double ElevationMax => this._i.ElevationMax;

		///<summary>
		///
		///</summary>
		public double ElevationAt(double Offset) 
		{
			return this._i.ElevationAt(Offset);
		}

		///<summary>
		///
		///</summary>
		public double LengthLeft => this._i.LengthLeft;

		///<summary>
		///
		///</summary>
		public double LengthRight => this._i.LengthRight;

		///<summary>
		///
		///</summary>
		public dynamic DataType => this._i.DataType;

		///<summary>
		///
		///</summary>
		public void Set_DataType(Autodesk.AECC.Interop.Land.AeccSectionDataType pVal) 
		{
			this._i.DataType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic StaticDynamic => this._i.StaticDynamic;

		///<summary>
		///
		///</summary>
		public void Set_StaticDynamic(Autodesk.AECC.Interop.Land.AeccSectionStateType pVal) 
		{
			this._i.StaticDynamic = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(object ppVal) 
		{
			this._i.Style = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelGroups(object SectionView) 
		{
			return this._i.LabelGroups(SectionView);
		}

		///<summary>
		///
		///</summary>
		public dynamic Links => this._i.Links;
	}
}
