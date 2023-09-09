namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSection2 
	{
		public AXDBLib.IAcadSection2 _i;
		internal AcadSection2(object AcadSection2_object) 
		{
			this._i = AcadSection2_object as AXDBLib.IAcadSection2;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic State2 => this._i.State2;

		///<summary>
		///
		///</summary>
		public void Set_State2(AXDBLib.AcSectionState2 pVal) 
		{
			this._i.State2 = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SliceDepth => this._i.SliceDepth;

		///<summary>
		///
		///</summary>
		public void Set_SliceDepth(double pVal) 
		{
			this._i.SliceDepth = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SectionPlaneOffset => this._i.SectionPlaneOffset;

		///<summary>
		///
		///</summary>
		public void Set_SectionPlaneOffset(double pVal) 
		{
			this._i.SectionPlaneOffset = pVal;
		}
	}
}
