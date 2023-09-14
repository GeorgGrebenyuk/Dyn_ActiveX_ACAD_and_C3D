namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMInsertBlock 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadMInsertBlock _i;
		internal AcadMInsertBlock(object AcadMInsertBlock_object) 
		{
			this._i = AcadMInsertBlock_object as Autodesk.AutoCAD.Interop.Common.IAcadMInsertBlock;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Columns(dynamic NumColumns) 
		{
			this._i.Columns = NumColumns;
		}

		///<summary>
		///
		///</summary>
		public dynamic Columns => this._i.Columns;

		///<summary>
		///
		///</summary>
		public void Set_ColumnSpacing(double Spacing) 
		{
			this._i.ColumnSpacing = Spacing;
		}

		///<summary>
		///
		///</summary>
		public double ColumnSpacing => this._i.ColumnSpacing;

		///<summary>
		///
		///</summary>
		public void Set_Rows(dynamic NumRows) 
		{
			this._i.Rows = NumRows;
		}

		///<summary>
		///
		///</summary>
		public dynamic Rows => this._i.Rows;

		///<summary>
		///
		///</summary>
		public void Set_RowSpacing(double Spacing) 
		{
			this._i.RowSpacing = Spacing;
		}

		///<summary>
		///
		///</summary>
		public double RowSpacing => this._i.RowSpacing;
	}
}
