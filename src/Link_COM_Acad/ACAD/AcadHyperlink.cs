namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadHyperlink 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadHyperlink _i;
		internal AcadHyperlink(object AcadHyperlink_object) 
		{
			this._i = AcadHyperlink_object as Autodesk.AutoCAD.Interop.Common.IAcadHyperlink;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        ///
        ///</summary>
        public AcadHyperlink (dynamic AcadHyperlinks, string Name, object Description, object NamedLocation)
        {
            this._i =  AcadHyperlinks._i.Add(Name, Description, NamedLocation);
        }

        ///<summary>
        ///
        ///</summary>
        public void Set_URL(string URLPath) 
		{
			this._i.URL = URLPath;
		}

		///<summary>
		///
		///</summary>
		public string URL => this._i.URL;

		///<summary>
		///
		///</summary>
		public void Set_URLDescription(string Description) 
		{
			this._i.URLDescription = Description;
		}

		///<summary>
		///
		///</summary>
		public string URLDescription => this._i.URLDescription;

		///<summary>
		///
		///</summary>
		public dynamic Application => this._i.Application;

		///<summary>
		///
		///</summary>
		public void Delete() 
		{
			this._i.Delete();
		}

		///<summary>
		///
		///</summary>
		public void Set_URLNamedLocation(string Location) 
		{
			this._i.URLNamedLocation = Location;
		}

		///<summary>
		///
		///</summary>
		public string URLNamedLocation => this._i.URLNamedLocation;
	}
}
