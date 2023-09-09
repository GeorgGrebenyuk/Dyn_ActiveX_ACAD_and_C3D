namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPaperSpace 
	{
		public AXDBLib.IAcadPaperSpace _i;
		internal AcadPaperSpace(object AcadPaperSpace_object) 
		{
			this._i = AcadPaperSpace_object as AXDBLib.IAcadPaperSpace;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddPViewport(object Center,double Width,double Height) 
		{
			return this._i.AddPViewport(Center,Width,Height);
		}
	}
}
