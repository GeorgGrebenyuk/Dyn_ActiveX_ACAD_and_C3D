namespace DynAXDBLib 
{

    ///<summary>
    /// The line characteristics consisting of combinations of dashes, dots, and spaces/ It is not possible to create a linetype programmatically
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
        /// You can only create default linetypes programmatically.
        /// </summary>
        /// <param name="AcadLineTypes"></param>
        /// <param name="Name"></param>
        public AcadLineType(AcadLineTypes AcadLineTypes, string Name)
		{
            for (int i = 0; i < AcadLineTypes._i.Count; i++)
            {
                var obj = AcadLineTypes._i.Item(i);
                if (obj.Name == Name) this._i = obj;
            }
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
