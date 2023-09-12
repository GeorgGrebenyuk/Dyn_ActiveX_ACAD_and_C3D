namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadUCS 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadUCS _i;
		internal AcadUCS(object AcadUCS_object) 
		{
			this._i = AcadUCS_object as Autodesk.AutoCAD.Interop.Common.IAcadUCS;
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
		public object Origin => this._i.Origin;

		///<summary>
		///
		///</summary>
		public void Set_Origin(object Origin) 
		{
			this._i.Origin = Origin;
		}

		///<summary>
		///
		///</summary>
		public object XVector => this._i.XVector;

		///<summary>
		///
		///</summary>
		public void Set_XVector(object XVector) 
		{
			this._i.XVector = XVector;
		}

		///<summary>
		///
		///</summary>
		public object YVector => this._i.YVector;

		///<summary>
		///
		///</summary>
		public void Set_YVector(object YVector) 
		{
			this._i.YVector = YVector;
		}

		///<summary>
		///
		///</summary>
		public object GetUCSMatrix => this._i.GetUCSMatrix();
	}
}
