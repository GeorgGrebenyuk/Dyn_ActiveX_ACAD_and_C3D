using System;
using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadObject 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadObject _i;
		internal AcadObject(object AcadObject_object, int i = 0) 
		{
			this._i = AcadObject_object as Autodesk.AutoCAD.Interop.Common.IAcadObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Cast to AcadObject from any object
        /// </summary>
        /// <param name="AnyModelObject"></param>
        public AcadObject(dynamic AnyModelObject)
        {
            try
            {
                this._i = AnyModelObject._i as Autodesk.AutoCAD.Interop.Common.IAcadObject;
                if (this._i == null) throw new Exception("Invalid castings");
            }
            catch { }
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
		public long ObjectID => this._i.ObjectID;

		///<summary>
		///
		///</summary>
		public bool HasExtensionDictionary => this._i.HasExtensionDictionary;

		///<summary>
		///
		///</summary>
		public object GetExtensionDictionary => this._i.GetExtensionDictionary();

		///<summary>
		///
		///</summary>
		public long OwnerID => this._i.OwnerID;

		///<summary>
		///
		///</summary>
		private void HiddenField_Erase() 
		{
			
		}
	}
}
