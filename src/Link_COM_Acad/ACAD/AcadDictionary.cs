using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDictionary 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDictionary _i;
		internal AcadDictionary(object AcadDictionary_object) 
		{
			this._i = AcadDictionary_object as Autodesk.AutoCAD.Interop.Common.AcadDictionary;
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
		public AcadObject AddObject(string Keyword,string ObjectName) 
		{
			return new AcadObject(this._i.AddObject(Keyword,ObjectName));
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
		public AcadObject GetObject(string Name) 
		{
			return new AcadObject(this._i.GetObject(Name));
		}

		///<summary>
		///
		///</summary>
		public AcadObject Remove(string Name) 
		{
			return new AcadObject(this._i.Remove(Name));
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
		public AcadObject Item(object Index) 
		{
			return new AcadObject(this._i.Item(Index));
		}
        public List<AcadObject> GetAcadObjects()
        {
            List<AcadObject> es = new List<AcadObject>();
            foreach (var ent in this._i)
            {
                es.Add(new AcadObject(ent));
            }
            return es;
        }

        ///<summary>
        ///
        ///</summary>
        public int Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public AcadXRecord AddXRecord(string Keyword) 
		{
			return new AcadXRecord(this._i.AddXRecord(Keyword));
		}
	}
}
