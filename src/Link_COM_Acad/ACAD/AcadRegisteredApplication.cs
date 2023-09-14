namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRegisteredApplication 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadRegisteredApplication _i;
		internal AcadRegisteredApplication(object AcadRegisteredApplication_object) 
		{
			this._i = AcadRegisteredApplication_object as Autodesk.AutoCAD.Interop.Common.AcadRegisteredApplication;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Create new RegisteredApplication
        /// </summary>
        /// <param name="AcadRegisteredApplications"></param>
        /// <param name="name"></param>
        public AcadRegisteredApplication(AcadRegisteredApplications AcadRegisteredApplications, string name)
		{
			this._i = AcadRegisteredApplications._i.Add(name);
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
