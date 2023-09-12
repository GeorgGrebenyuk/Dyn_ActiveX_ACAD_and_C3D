namespace DynAXDBLib 
{

	///<summary>
	///Work with acad layout
	///</summary>
	public class AcadLayout 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLayout _i;
		internal AcadLayout(object AcadLayout_object) 
		{
			this._i = AcadLayout_object as Autodesk.AutoCAD.Interop.Common.AcadLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///
        ///</summary>
        public AcadLayout(AcadLayouts AcadLayouts, string Name)
        {
            this._i = AcadLayouts._i.Add(Name);
        }

        ///<summary>
        ///
        ///</summary>
        public AcadBlock Block => new AcadBlock(this._i.Block);

		///<summary>
		///
		///</summary>
		public int TabOrder => this._i.TabOrder;

		///<summary>
		///
		///</summary>
		public void Set_TabOrder(int pOrder) 
		{
			this._i.TabOrder = pOrder;
		}
	}
}
