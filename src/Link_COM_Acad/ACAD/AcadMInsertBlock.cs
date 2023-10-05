using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    /// A rectangular array of block references
    ///</summary>
    public class AcadMInsertBlock 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadMInsertBlock _i;
		internal AcadMInsertBlock(object AcadMInsertBlock_object) 
		{
			this._i = AcadMInsertBlock_object as Autodesk.AutoCAD.Interop.Common.AcadMInsertBlock;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}


        /// <summary>
        /// Inserts an array of blocks
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="InsertionPoint">The 3D WCS coordinates at which to insert the array of blocks</param>
        /// <param name="Name">The name of the MInsertBlock. You cannot precede the name of an MInsertBlock with an asterisk to separate the block's objects during insertion, as you can with a standard Block</param>
        /// <param name="Xscale">The X scale factor</param>
        /// <param name="Yscale">The Y scale factor</param>
        /// <param name="Zscale">The Z scale factor</param>
        /// <param name="Rotation">The rotation angle in radians</param>
        /// <param name="NumRows">A positive integer representing the number of rows for the array</param>
        /// <param name="NumColumns"> positive integer representing the number of columns for the array</param>
        /// <param name="RowSpacing">The distance between the array rows</param>
        /// <param name="ColumnSpacing">The distance between the array columns</param>
        public AcadMInsertBlock (dynamic AcadBlock, Point InsertionPoint, string Name, double Xscale, double Yscale, double Zscale, double Rotation, int NumRows, int NumColumns, int RowSpacing, int ColumnSpacing)
		{
			this._i = AcadBlock._i.AddMInsertBlock(Technical.PointByDynPoint(InsertionPoint), Name, Xscale, Yscale, Zscale, Rotation, NumRows, NumColumns, RowSpacing, ColumnSpacing);
		}

        ///<summary>
        ///Specifies the number of columns in a block array or table
        ///</summary>
        public void Set_Columns(int NumColumns) 
		{
			this._i.Columns = NumColumns;
		}

        ///<summary>
        ///Specifies the number of columns in a block array or table
        ///</summary>
        public int Columns => this._i.Columns;

        ///<summary>
        ///Specifies the spacing of the columns in a block array
        ///</summary>
        public void Set_ColumnSpacing(double Spacing) 
		{
			this._i.ColumnSpacing = Spacing;
		}

        ///<summary>
        ///Specifies the spacing of the columns in a block array
        ///</summary>
        public double ColumnSpacing => this._i.ColumnSpacing;

        ///<summary>
        /// Specifies the number of rows in a block array or table
        ///</summary>
        public void Set_Rows(int NumRows) 
		{
			this._i.Rows = NumRows;
		}

        ///<summary>
        /// Specifies the number of rows in a block array or table
        ///</summary>
        public int Rows => this._i.Rows;

        ///<summary>
        ///Specifies the spacing of the rows in a block array
        ///</summary>
        public void Set_RowSpacing(double Spacing) 
		{
			this._i.RowSpacing = Spacing;
		}

        ///<summary>
        ///Specifies the spacing of the rows in a block array
        ///</summary>
        public double RowSpacing => this._i.RowSpacing;
	}
}
