using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadObject 
	{
		public AXDBLib.IAcadObject _i;
		internal AcadObject(object AcadObject_object) 
		{
			this._i = AcadObject_object as AXDBLib.IAcadObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Handle => this._i.Handle;

		///<summary>
		///
		///</summary>
		public string ObjectName => this._i.ObjectName;

		///<summary>
		///
		///</summary>
		public List<object> GetXData(string AppName) 
		{
			object XDataType;
			object XDataValue;

            this._i.GetXData(AppName,out XDataType,out XDataValue);
			return new List<object> { XDataType, XDataValue };
		}

		///<summary>
		///
		///</summary>
		public void SetXData(object XDataType,object XDataValue) 
		{
			this._i.SetXData(XDataType,XDataValue);
		}

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
		public dynamic ObjectID => this._i.ObjectID;

		///<summary>
		///
		///</summary>
		public dynamic Application => this._i.Application;

		///<summary>
		///
		///</summary>
		public dynamic Database => this._i.Database;

		///<summary>
		///
		///</summary>
		public bool HasExtensionDictionary => this._i.HasExtensionDictionary;

		///<summary>
		///
		///</summary>
		public dynamic GetExtensionDictionary => this._i.GetExtensionDictionary();

		///<summary>
		///
		///</summary>
		public dynamic OwnerID => this._i.OwnerID;

		///<summary>
		///
		///</summary>
		public dynamic Document => this._i.Document;

		///<summary>
		///
		///</summary>
		private void HiddenField_Erase() 
		{
			
		}
	}
}
