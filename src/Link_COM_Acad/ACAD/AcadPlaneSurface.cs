namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPlaneSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPlaneSurface _i;
		internal AcadPlaneSurface(object AcadPlaneSurface_object) 
		{
			this._i = AcadPlaneSurface_object as Autodesk.AutoCAD.Interop.Common.AcadPlaneSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
