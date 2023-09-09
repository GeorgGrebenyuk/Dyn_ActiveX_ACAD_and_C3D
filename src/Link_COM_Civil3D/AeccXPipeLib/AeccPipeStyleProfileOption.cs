namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStyleProfileOption 
	{
		public AeccXPipeLib.IAeccPipeStyleProfileOption _i;
		internal AeccPipeStyleProfileOption(object AeccPipeStyleProfileOption_object) 
		{
			this._i = AeccPipeStyleProfileOption_object as AeccXPipeLib.IAeccPipeStyleProfileOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CrossingHatch => this._i.CrossingHatch;

		///<summary>
		///
		///</summary>
		public void Set_CrossingHatch(AeccXPipeLib.AeccPipeHatchOptions pnHatchOptions) 
		{
			this._i.CrossingHatch = pnHatchOptions;
		}
	}
}
