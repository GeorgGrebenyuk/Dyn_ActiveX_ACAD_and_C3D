using System;
using System.Collections.Generic;

namespace DynAXDBLib 
{

    ///<summary>
    /// The standard interface for a basic AutoCAD object. IAcadObject interface represents the default interface for most AutoCAD objects
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
        /// Gets the handle of an object (unique identificator per that drawing)
        ///</summary>
        public string Handle => this._i.Handle;

        ///<summary>
        /// Gets the AutoCAD class name of the object
        ///</summary>
        public string ObjectName => this._i.ObjectName;

        /// <summary>
		/// Gets the extended data (XData) associated with an object
		/// </summary>
		/// <param name="AppName">A NULL string will return all the data attached to the object, regardless of the application that created it. Supplying an application name will return only the data that was created by the specified application</param>
		/// <returns>An array of short integer values that represent the DXF group code values for each value in the extended data (XData).An array of values that make up the extended data (XData). </returns>
        public List<object> GetXData(string AppName) 
		{
			object XDataType;
			object XDataValue;

            this._i.GetXData(AppName,out XDataType,out XDataValue);
			return new List<object> { XDataType, XDataValue };
		}

        /// <summary>
        /// Sets the extended data (XData) associated with an object
        /// </summary>
        /// <param name="XDataType">An array of short integer values that represent the DXF group code values for each value in the extended data (XData)</param>
        /// <param name="XDataValue">An array of values that make up the extended data (XData)</param>
        public void SetXData(object XDataType,object XDataValue) 
		{
			this._i.SetXData(XDataType,XDataValue);
		}

        ///<summary>
        ///Deletes a specified object or a set of saved layer settings
        ///</summary>
        public void Delete() 
		{
			this._i.Delete();
		}

        ///<summary>
        ///Gets the object ID
        ///</summary>
        public long ObjectID => this._i.ObjectID;

        ///<summary>
        ///Determines whether the object has an extension dictionary associated with it
        ///</summary>
        public bool HasExtensionDictionary => this._i.HasExtensionDictionary;

        ///<summary>
        ///Gets the extension dictionary associated with an object
        ///</summary>
        public AcadDictionary GetExtensionDictionary => new AcadDictionary(this._i.GetExtensionDictionary());

        ///<summary>
        ///Gets the object ID of the owner (parent) object.
        ///</summary>
        public long OwnerID => this._i.OwnerID;
	}
}
