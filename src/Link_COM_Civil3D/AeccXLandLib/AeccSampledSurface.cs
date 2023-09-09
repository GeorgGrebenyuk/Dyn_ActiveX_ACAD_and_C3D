namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampledSurface 
	{
		public AeccXLandLib.IAeccSampledSurface _i;
		internal AeccSampledSurface(object AeccSampledSurface_object) 
		{
			this._i = AeccSampledSurface_object as AeccXLandLib.IAeccSampledSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;

		///<summary>
		///
		///</summary>
		public dynamic SectionStyle => this._i.SectionStyle;

		///<summary>
		///
		///</summary>
		public void Set_SectionStyle(object ppVal) 
		{
			this._i.SectionStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic UpdateMode => this._i.UpdateMode;

		///<summary>
		///
		///</summary>
		public void Set_UpdateMode(AeccXLandLib.AeccSectionStateType pVal) 
		{
			this._i.UpdateMode = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Sample => this._i.Sample;

		///<summary>
		///
		///</summary>
		public void Set_Sample(bool pVal) 
		{
			this._i.Sample = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AcadEntity => this._i.AcadEntity;
	}
}
