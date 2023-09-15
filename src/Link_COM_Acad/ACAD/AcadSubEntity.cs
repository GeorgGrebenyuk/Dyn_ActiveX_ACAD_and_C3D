namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSubEntity 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSubEntity _i;
		internal AcadSubEntity(object AcadSubEntity_object) 
		{
			this._i = AcadSubEntity_object as Autodesk.AutoCAD.Interop.Common.AcadSubEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void OnModified() 
		{
			this._i.OnModified();
		}

		///<summary>
		///
		///</summary>
		public string ObjectName => this._i.ObjectName;

		///<summary>
		///
		///</summary>
		public dynamic color => this._i.color;

		///<summary>
		///
		///</summary>
		public void Set_color(dynamic pColor) 
		{
			this._i.color = pColor;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public string Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public dynamic LinetypeScale => this._i.LinetypeScale;

		///<summary>
		///
		///</summary>
		public string PlotStyleName => this._i.PlotStyleName;

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public dynamic Hyperlinks => this._i.Hyperlinks;
	}
}
