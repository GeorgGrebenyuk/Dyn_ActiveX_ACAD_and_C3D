using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSummaryInfo 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSummaryInfo _i;
		internal AcadSummaryInfo(object AcadSummaryInfo_object) 
		{
			this._i = AcadSummaryInfo_object as Autodesk.AutoCAD.Interop.Common.AcadSummaryInfo;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Author => this._i.Author;

		///<summary>
		///
		///</summary>
		public void Set_Author(string pAuthor) 
		{
			this._i.Author = pAuthor;
		}

		///<summary>
		///
		///</summary>
		public string Comments => this._i.Comments;

		///<summary>
		///
		///</summary>
		public void Set_Comments(string pComments) 
		{
			this._i.Comments = pComments;
		}

		///<summary>
		///
		///</summary>
		public string HyperlinkBase => this._i.HyperlinkBase;

		///<summary>
		///
		///</summary>
		public void Set_HyperlinkBase(string pHyperlinkBase) 
		{
			this._i.HyperlinkBase = pHyperlinkBase;
		}

		///<summary>
		///
		///</summary>
		public string Keywords => this._i.Keywords;

		///<summary>
		///
		///</summary>
		public void Set_Keywords(string pKeywords) 
		{
			this._i.Keywords = pKeywords;
		}

		///<summary>
		///
		///</summary>
		public string LastSavedBy => this._i.LastSavedBy;

		///<summary>
		///
		///</summary>
		public void Set_LastSavedBy(string pLastSavedBy) 
		{
			this._i.LastSavedBy = pLastSavedBy;
		}

		///<summary>
		///
		///</summary>
		public string RevisionNumber => this._i.RevisionNumber;

		///<summary>
		///
		///</summary>
		public void Set_RevisionNumber(string pRevisionNumber) 
		{
			this._i.RevisionNumber = pRevisionNumber;
		}

		///<summary>
		///
		///</summary>
		public string Subject => this._i.Subject;

		///<summary>
		///
		///</summary>
		public void Set_Subject(string pSubject) 
		{
			this._i.Subject = pSubject;
		}

		///<summary>
		///
		///</summary>
		public string Title => this._i.Title;

		///<summary>
		///
		///</summary>
		public void Set_Title(string pTitle) 
		{
			this._i.Title = pTitle;
		}

		///<summary>
		///
		///</summary>
		public int NumCustomInfo => this._i.NumCustomInfo();

		///<summary>
		///
		///</summary>
		public List<string> GetCustomByIndex(int Index) 
		{
			string pKey;
			string pValue;
			this._i.GetCustomByIndex(Index,out pKey,out pValue);
			return new List<string> { pKey, pValue };
		}

		///<summary>
		///
		///</summary>
		public string GetCustomByKey(string key) 
		{
			string pValue;
            this._i.GetCustomByKey(key,out pValue);
			return pValue;
		}

		///<summary>
		///
		///</summary>
		public void SetCustomByIndex(int Index,string key,string Value) 
		{
			this._i.SetCustomByIndex(Index,key,Value);
		}

		///<summary>
		///
		///</summary>
		public void SetCustomByKey(string key,string Value) 
		{
			this._i.SetCustomByKey(key,Value);
		}

		///<summary>
		///
		///</summary>
		public void AddCustomInfo(string key,string Value) 
		{
			this._i.AddCustomInfo(key,Value);
		}

		///<summary>
		///
		///</summary>
		public void RemoveCustomByIndex(int Index) 
		{
			this._i.RemoveCustomByIndex(Index);
		}

		///<summary>
		///
		///</summary>
		public void RemoveCustomByKey(string key) 
		{
			this._i.RemoveCustomByKey(key);
		}
	}
}
