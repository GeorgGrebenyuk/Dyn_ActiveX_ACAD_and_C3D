namespace DynAXDBLib 
{

    ///<summary>
    /// An external application that has been added to the drawing. To be recognized by AutoCAD, an application must register the name or names that it uses. The application name needs to be registered only once per drawing. Application names are saved with the extended data of each entity that uses them. Every instance of extended data referenced in a drawing must have its application registered in the drawing
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
