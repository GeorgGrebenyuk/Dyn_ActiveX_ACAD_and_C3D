namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayout 
	{
		public AXDBLib.IAcadLayout _i;
		internal AcadLayout(object AcadLayout_object) 
		{
			this._i = AcadLayout_object as AXDBLib.IAcadLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Block => this._i.Block;

		///<summary>
		///
		///</summary>
		public dynamic TabOrder => this._i.TabOrder;

		///<summary>
		///
		///</summary>
		public void Set_TabOrder(dynamic pOrder) 
		{
			this._i.TabOrder = pOrder;
		}
	}
}
