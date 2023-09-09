namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileOverride 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileOverride _i;
		internal AeccProfileOverride(object AeccProfileOverride_object) 
		{
			this._i = AeccProfileOverride_object as Autodesk.AECC.Interop.Land.IAeccProfileOverride;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Profile => this._i.Profile;

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
