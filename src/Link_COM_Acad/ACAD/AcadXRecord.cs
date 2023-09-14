using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadXRecord 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadXRecord _i;
		internal AcadXRecord(object AcadXRecord_object) 
		{
			this._i = AcadXRecord_object as Autodesk.AutoCAD.Interop.Common.IAcadXRecord;
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
		public List<object> GetXRecordData() 
		{
			object XRecordDataType;
			object XRecordDataValue;

            this._i.GetXRecordData(out XRecordDataType,out XRecordDataValue);
			return new List<object> { XRecordDataType, XRecordDataValue };
		}

		///<summary>
		///
		///</summary>
		public void SetXRecordData(object XRecordDataType,object XRecordDataValue) 
		{
			this._i.SetXRecordData(XRecordDataType,XRecordDataValue);
		}

		///<summary>
		///
		///</summary>
		public bool TranslateIDs => this._i.TranslateIDs;

		///<summary>
		///
		///</summary>
		public void Set_TranslateIDs(bool xlateIds) 
		{
			this._i.TranslateIDs = xlateIds;
		}
	}
}
