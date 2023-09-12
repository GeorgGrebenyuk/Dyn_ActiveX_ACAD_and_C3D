namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadNurbSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadNurbSurface _i;
		internal AcadNurbSurface(object AcadNurbSurface_object) 
		{
			this._i = AcadNurbSurface_object as Autodesk.AutoCAD.Interop.Common.IAcadNurbSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool CvHullDisplay => this._i.CvHullDisplay;

		///<summary>
		///
		///</summary>
		public void Set_CvHullDisplay(bool Display) 
		{
			this._i.CvHullDisplay = Display;
		}
	}
}
