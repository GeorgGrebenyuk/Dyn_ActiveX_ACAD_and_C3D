using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadExternalReference 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadExternalReference _i;
		internal AcadExternalReference(object AcadExternalReference_object) 
		{
			this._i = AcadExternalReference_object as Autodesk.AutoCAD.Interop.Common.AcadExternalReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        ///Create new AcadExternalReference
        ///</summary>
        public AcadExternalReference (dynamic AcadBlock, string PathName, string Name, 
			Point InsertionPoint, double Xscale, double Yscale, double Zscale, double Rotation, bool bOverlay)
		{
			this._i =  AcadBlock._i.AttachExternalReference(PathName, Name, 
				InsertionPoint, Xscale, Yscale, Zscale, Rotation, bOverlay);
		}
		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public void Set_Path(string bstrName) 
		{
			this._i.Path = bstrName;
		}

		///<summary>
		///
		///</summary>
		public bool LayerPropertyOverrides => this._i.LayerPropertyOverrides;
	}
}
