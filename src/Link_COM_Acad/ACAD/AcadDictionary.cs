namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDictionary 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadDictionary _i;
		internal AcadDictionary(object AcadDictionary_object) 
		{
			this._i = AcadDictionary_object as Autodesk.AutoCAD.Interop.Common.IAcadDictionary;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        ///
        ///</summary>
        public AcadDictionary (AcadDictionaries AcadDictionaries, string Name)
        {
			this._i = AcadDictionaries._i.Add(Name);
        }

        ///<summary>
        ///
        ///</summary>
        public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AddObject(string Keyword,string ObjectName) 
		{
			return this._i.AddObject(Keyword,ObjectName);
		}

		///<summary>
		///
		///</summary>
		public string GetName(dynamic Object) 
		{
			return this._i.GetName(Object);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetObject(string Name) 
		{
			return this._i.GetObject(Name);
		}

		///<summary>
		///
		///</summary>
		public dynamic Remove(string Name) 
		{
			return this._i.Remove(Name);
		}

		///<summary>
		///
		///</summary>
		public void Rename(string OldName,string NewName) 
		{
			this._i.Rename(OldName,NewName);
		}

		///<summary>
		///
		///</summary>
		public void Replace(string OldName,dynamic pObj) 
		{
			this._i.Replace(OldName,pObj);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic AddXRecord(string Keyword) 
		{
			return this._i.AddXRecord(Keyword);
		}
	}
}
