namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrame 
	{
		public Autodesk.AECC.Interop.Land.IAeccViewFrame _i;
		internal AeccViewFrame(object AeccViewFrame_object) 
		{
			this._i = AeccViewFrame_object as Autodesk.AECC.Interop.Land.IAeccViewFrame;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
