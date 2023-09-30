using System;
using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadObject 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadObject _i;
		internal AcadObject(object AcadObject_object) 
		{
			this._i = AcadObject_object as Autodesk.AutoCAD.Interop.Common.AcadObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Cast to AcadObject from any object
        /// </summary>
        /// <param name="AnyModelObject"></param>
        public static AcadObject ByAnyObject(dynamic AnyModelObject)
        {
            try
            {
                var casted_interface = AnyModelObject._i as Autodesk.AutoCAD.Interop.Common.AcadObject;
                if (casted_interface == null) throw new Exception("Invalid castings");
                return new AcadObject(casted_interface);
            }
            catch { }
            throw new Exception("Invalid castings");
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
