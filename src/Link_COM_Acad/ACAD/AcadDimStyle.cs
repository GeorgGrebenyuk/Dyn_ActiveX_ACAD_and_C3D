namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDimStyle 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadDimStyle _i;
		internal AcadDimStyle(object AcadDimStyle_object) 
		{
			this._i = AcadDimStyle_object as Autodesk.AutoCAD.Interop.Common.IAcadDimStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}

		///<summary>
		///
		///</summary>
		public void CopyFrom(dynamic StyleSource) 
		{
			this._i.CopyFrom(StyleSource);
		}
	}
}
