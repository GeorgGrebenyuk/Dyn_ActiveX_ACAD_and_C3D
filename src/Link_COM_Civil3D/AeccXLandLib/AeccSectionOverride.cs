namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionOverride 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionOverride _i;
		internal AeccSectionOverride(object AeccSectionOverride_object) 
		{
			this._i = AeccSectionOverride_object as Autodesk.AECC.Interop.Land.IAeccSectionOverride;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Section => this._i.Section;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(object pVal) 
		{
			this._i.Style = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelSet => this._i.LabelSet;

		///<summary>
		///
		///</summary>
		public void ImportLabelSet(dynamic LabelStyleSet) 
		{
			this._i.ImportLabelSet(LabelStyleSet);
		}

		///<summary>
		///
		///</summary>
		public dynamic ExportLabelSet(string Name) 
		{
			return this._i.ExportLabelSet(Name);
		}
	}
}
