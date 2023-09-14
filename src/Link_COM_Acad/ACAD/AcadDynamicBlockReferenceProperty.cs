namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDynamicBlockReferenceProperty 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDynamicBlockReferenceProperty _i;
		internal AcadDynamicBlockReferenceProperty(object AcadDynamicBlockReferenceProperty_object) 
		{
			this._i = AcadDynamicBlockReferenceProperty_object as Autodesk.AutoCAD.Interop.Common.AcadDynamicBlockReferenceProperty;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string PropertyName => this._i.PropertyName;

		///<summary>
		///
		///</summary>
		public bool ReadOnly => this._i.ReadOnly;

		///<summary>
		///
		///</summary>
		public bool show => this._i.show;

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public object AllowedValues => this._i.AllowedValues;

		///<summary>
		///
		///</summary>
		public object Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(object Value) 
		{
			this._i.Value = Value;
		}

		///<summary>
		///
		///</summary>
		public object UnitsType => this._i.UnitsType.ToString();
	}
}
