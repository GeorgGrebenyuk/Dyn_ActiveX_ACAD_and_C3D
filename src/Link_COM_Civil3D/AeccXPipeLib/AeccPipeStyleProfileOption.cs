namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStyleProfileOption 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeStyleProfileOption _i;
		internal AeccPipeStyleProfileOption(object AeccPipeStyleProfileOption_object) 
		{
			this._i = AeccPipeStyleProfileOption_object as Autodesk.AECC.Interop.Pipe.IAeccPipeStyleProfileOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CrossingHatch => this._i.CrossingHatch;

		///<summary>
		///
		///</summary>
		public void Set_CrossingHatch(Autodesk.AECC.Interop.Pipe.AeccPipeHatchOptions pnHatchOptions) 
		{
			this._i.CrossingHatch = pnHatchOptions;
		}
	}
}
