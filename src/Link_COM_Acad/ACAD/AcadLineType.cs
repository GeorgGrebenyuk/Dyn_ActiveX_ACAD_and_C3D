namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLineType 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLineType _i;
		internal AcadLineType(object AcadLineType_object) 
		{
			this._i = AcadLineType_object as Autodesk.AutoCAD.Interop.Common.AcadLineType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Create new AcadLineType by name
        /// </summary>
        /// <param name="AcadLineTypes"></param>
        /// <param name="Name"></param>
        public AcadLineType(AcadLineTypes AcadLineTypes, string Name)
		{
			this._i = AcadLineTypes._i.Add(Name);
        }

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string bstrDes) 
		{
			this._i.Description = bstrDes;
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
	}
}
