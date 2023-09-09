namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadNurbSurface 
	{
		public AXDBLib.IAcadNurbSurface _i;
		internal AcadNurbSurface(object AcadNurbSurface_object) 
		{
			this._i = AcadNurbSurface_object as AXDBLib.IAcadNurbSurface;
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
