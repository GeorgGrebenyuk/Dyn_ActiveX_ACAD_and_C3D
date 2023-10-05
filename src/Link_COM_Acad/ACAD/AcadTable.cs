using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DynAXDBLib 
{

    ///<summary>
    /// AutoCAD table object
    ///</summary>
    public class AcadTable 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadTable _i;
		internal AcadTable(object AcadTable_object) 
		{
			this._i = AcadTable_object as Autodesk.AutoCAD.Interop.Common.AcadTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadTable(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadTable;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }


        /// <summary>
        /// Adds a table to a drawing
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="InsertionPoint">The 3D WCS coordinates in the drawing where the table is inserted</param>
        /// <param name="NumRows">The number of rows in the table</param>
        /// <param name="NumColumns">The number of columns in the table</param>
        /// <param name="RowHeight">The height of the rows in the table</param>
        /// <param name="ColWidth">The width of the columns in the table</param>
        public AcadTable(AcadBlock AcadBlock, Point InsertionPoint, int NumRows, int NumColumns, 
			double RowHeight, double ColWidth)
        {
            this._i =  AcadBlock._i.AddTable(Technical.PointByDynPoint(InsertionPoint), NumRows,
				NumColumns, RowHeight, ColWidth);
        }
        ///<summary>
        ///
        ///</summary>
        public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public void Set_StyleName(string bstrName) 
		{
			this._i.StyleName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public int Rows => this._i.Rows;

		///<summary>
		///
		///</summary>
		public void Set_Rows(int pRows) 
		{
			this._i.Rows = pRows;
		}

		///<summary>
		///
		///</summary>
		public int Columns => this._i.Columns;

		///<summary>
		///
		///</summary>
		public void Set_Columns(int pColumns) 
		{
			this._i.Columns = pColumns;
		}

		///<summary>
		///
		///</summary>
		public object FlowDirection => this._i.FlowDirection;

		///<summary>
		///
		///</summary>
		public void Set_FlowDirection(Autodesk.AutoCAD.Interop.Common.AcTableDirection pFlow) 
		{
			this._i.FlowDirection = pFlow;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double pWidth) 
		{
			this._i.Width = pWidth;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double pHeight) 
		{
			this._i.Height = pHeight;
		}

		///<summary>
		///
		///</summary>
		public double VertCellMargin => this._i.VertCellMargin;

		///<summary>
		///
		///</summary>
		public void Set_VertCellMargin(double pGap) 
		{
			this._i.VertCellMargin = pGap;
		}

		///<summary>
		///
		///</summary>
		public double HorzCellMargin => this._i.HorzCellMargin;

		///<summary>
		///
		///</summary>
		public void Set_HorzCellMargin(double pGap) 
		{
			this._i.HorzCellMargin = pGap;
		}

        ///<summary>
        ///
        ///</summary>
        public Autodesk.DesignScript.Geometry.Point InsertionPoint =>
            Technical.PointByDoubleArray(this._i.InsertionPoint);

        ///<summary>
        ///
        ///</summary>
        public void Set_InsertionPoint(object insPoint)
        {
            this._i.InsertionPoint = insPoint;
        }

        ///<summary>
        ///
        ///</summary>
        public double GetColumnWidth(int col) 
		{
			return this._i.GetColumnWidth(col);
		}

		///<summary>
		///
		///</summary>
		public void SetColumnWidth(int col,double Width) 
		{
			this._i.SetColumnWidth(col,Width);
		}

		///<summary>
		///
		///</summary>
		public void Set_ColumnWidth(double rhs) 
		{
			this._i.ColumnWidth = rhs;
		}

		///<summary>
		///
		///</summary>
		public double GetRowHeight(int row) 
		{
			return this._i.GetRowHeight(row);
		}

		///<summary>
		///
		///</summary>
		public void SetRowHeight(int row,double Height) 
		{
			this._i.SetRowHeight(row,Height);
		}

		///<summary>
		///
		///</summary>
		public void Set_RowHeight(double rhs) 
		{
			this._i.RowHeight = rhs;
		}

		///<summary>
		///
		///</summary>
		public double GetMinimumColumnWidth(int col) 
		{
			return this._i.GetMinimumColumnWidth(col);
		}

		///<summary>
		///
		///</summary>
		public double GetMinimumRowHeight(int row) 
		{
			return this._i.GetMinimumRowHeight(row);
		}

		///<summary>
		///
		///</summary>
		public double MinimumTableWidth => this._i.MinimumTableWidth;

		///<summary>
		///
		///</summary>
		public double MinimumTableHeight => this._i.MinimumTableHeight;

        ///<summary>
        ///
        ///</summary>
        public Vector Direction => Technical.VectorByDoubleArray(this._i.Direction);

        ///<summary>
        ///
        ///</summary>
        public void Set_Direction(Vector DirectionVector)
        {
            this._i.Direction = Technical.VectorByDynVector(DirectionVector);
        }

        ///<summary>
        ///
        ///</summary>
        public bool TitleSuppressed => this._i.TitleSuppressed;

		///<summary>
		///
		///</summary>
		public void Set_TitleSuppressed(bool bValue) 
		{
			this._i.TitleSuppressed = bValue;
		}

		///<summary>
		///
		///</summary>
		public bool HeaderSuppressed => this._i.HeaderSuppressed;

		///<summary>
		///
		///</summary>
		public void Set_HeaderSuppressed(bool bValue) 
		{
			this._i.HeaderSuppressed = bValue;
		}

		///<summary>
		///
		///</summary>
		public dynamic GetAlignment(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetAlignment(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetAlignment(int rowTypes,Autodesk.AutoCAD.Interop.Common.AcCellAlignment cellAlignment) 
		{
			this._i.SetAlignment(rowTypes,cellAlignment);
		}

		///<summary>
		///
		///</summary>
		public bool GetBackgroundColorNone(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetBackgroundColorNone(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetBackgroundColorNone(int rowTypes,bool bValue) 
		{
			this._i.SetBackgroundColorNone(rowTypes,bValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetBackgroundColor(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetBackgroundColor(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetBackgroundColor(int rowTypes,dynamic pColor) 
		{
			this._i.SetBackgroundColor(rowTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetContentColor(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetContentColor(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetContentColor(int rowTypes,dynamic pColor) 
		{
			this._i.SetContentColor(rowTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public string GetTextStyle(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetTextStyle(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetTextStyle(int rowTypes,string bstrName) 
		{
			this._i.SetTextStyle(rowTypes,bstrName);
		}

		///<summary>
		///
		///</summary>
		public double GetTextHeight(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetTextHeight(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetTextHeight(int rowTypes,double TextHeight) 
		{
			this._i.SetTextHeight(rowTypes,TextHeight);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetGridLineWeight(Autodesk.AutoCAD.Interop.Common.AcGridLineType gridLineType,Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetGridLineWeight(gridLineType,rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridLineWeight(int gridLineTypes,int rowTypes,dynamic Lineweight) 
		{
			this._i.SetGridLineWeight(gridLineTypes,rowTypes,Lineweight);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetGridColor(Autodesk.AutoCAD.Interop.Common.AcGridLineType gridLineType,Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetGridColor(gridLineType,rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridColor(int gridLineTypes,int rowTypes,dynamic pColor) 
		{
			this._i.SetGridColor(gridLineTypes,rowTypes,pColor);
		}

		///<summary>
		///
		///</summary>
		public bool GetGridVisibility(Autodesk.AutoCAD.Interop.Common.AcGridLineType gridLineType,Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetGridVisibility(gridLineType,rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridVisibility(int gridLineTypes,int rowTypes,bool bValue) 
		{
			this._i.SetGridVisibility(gridLineTypes,rowTypes,bValue);
		}

		///<summary>
		///
		///</summary>
		public object TableStyleOverrides => this._i.TableStyleOverrides;

		///<summary>
		///
		///</summary>
		public void ClearTableStyleOverrides(int flag) 
		{
			this._i.ClearTableStyleOverrides(flag);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellType(int row,int col) 
		{
			return this._i.GetCellType(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellType(int row,int col,Autodesk.AutoCAD.Interop.Common.AcCellType CellType) 
		{
			this._i.SetCellType(row,col,CellType);
		}

		///<summary>
		///
		///</summary>
		public object GetCellExtents(int row,int col,bool bOuterCell) 
		{
			return this._i.GetCellExtents(row,col,bOuterCell);
		}

		///<summary>
		///
		///</summary>
		public object GetAttachmentPoint(int row,int col) 
		{
			return this._i.GetAttachmentPoint(row,col);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellAlignment(int row,int col) 
		{
			return this._i.GetCellAlignment(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellAlignment(int row,int col,Autodesk.AutoCAD.Interop.Common.AcCellAlignment cellAlignment) 
		{
			this._i.SetCellAlignment(row,col,cellAlignment);
		}

		///<summary>
		///
		///</summary>
		public bool GetCellBackgroundColorNone(int row,int col) 
		{
			return this._i.GetCellBackgroundColorNone(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellBackgroundColorNone(int row,int col,bool bValue) 
		{
			this._i.SetCellBackgroundColorNone(row,col,bValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellBackgroundColor(int row,int col) 
		{
			return this._i.GetCellBackgroundColor(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellBackgroundColor(int row,int col,dynamic pColor) 
		{
			this._i.SetCellBackgroundColor(row,col,pColor);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellContentColor(int row,int col) 
		{
			return this._i.GetCellContentColor(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellContentColor(int row,int col,dynamic pColor) 
		{
			this._i.SetCellContentColor(row,col,pColor);
		}

		///<summary>
		///
		///</summary>
		public object GetCellStyleOverrides(int row,int col) 
		{
			return this._i.GetCellStyleOverrides(row,col);
		}

		///<summary>
		///
		///</summary>
		public void DeleteCellContent(int row,int col) 
		{
			this._i.DeleteCellContent(row,col);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetRowType(int row) 
		{
			return this._i.GetRowType(row);
		}

		///<summary>
		///
		///</summary>
		public string GetText(int row,int col) 
		{
			return this._i.GetText(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetText(int row,int col,string pStr) 
		{
			this._i.SetText(row,col,pStr);
		}

		///<summary>
		///
		///</summary>
		public string GetCellTextStyle(int row,int col) 
		{
			return this._i.GetCellTextStyle(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellTextStyle(int row,int col,string bstrName) 
		{
			this._i.SetCellTextStyle(row,col,bstrName);
		}

		///<summary>
		///
		///</summary>
		public double GetCellTextHeight(int row,int col) 
		{
			return this._i.GetCellTextHeight(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellTextHeight(int row,int col,double TextHeight) 
		{
			this._i.SetCellTextHeight(row,col,TextHeight);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetTextRotation(int row,int col) 
		{
			return this._i.GetTextRotation(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetTextRotation(int row,int col,Autodesk.AutoCAD.Interop.Common.AcRotationAngle TextRotation) 
		{
			this._i.SetTextRotation(row,col,TextRotation);
		}

		///<summary>
		///
		///</summary>
		public bool GetAutoScale(int row,int col) 
		{
			return this._i.GetAutoScale(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetAutoScale(int row,int col,bool bValue) 
		{
			this._i.SetAutoScale(row,col,bValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetBlockTableRecordId(int row,int col) 
		{
			return this._i.GetBlockTableRecordId(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockTableRecordId(int row,int col,dynamic blkId,bool bAutoFit) 
		{
			this._i.SetBlockTableRecordId(row,col,blkId,bAutoFit);
		}

		///<summary>
		///
		///</summary>
		public double GetBlockScale(int row,int col) 
		{
			return this._i.GetBlockScale(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockScale(int row,int col,double blkScale) 
		{
			this._i.SetBlockScale(row,col,blkScale);
		}

		///<summary>
		///
		///</summary>
		public double GetBlockRotation(int row,int col) 
		{
			return this._i.GetBlockRotation(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockRotation(int row,int col,double blkRotation) 
		{
			this._i.SetBlockRotation(row,col,blkRotation);
		}

		///<summary>
		///
		///</summary>
		public string GetBlockAttributeValue(int row,int col,dynamic attdefId) 
		{
			return this._i.GetBlockAttributeValue(row,col,attdefId);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockAttributeValue(int row,int col,dynamic attdefId,string bstrValue) 
		{
			this._i.SetBlockAttributeValue(row,col,attdefId,bstrValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellGridLineWeight(int row,int col,Autodesk.AutoCAD.Interop.Common.AcCellEdgeMask edge) 
		{
			return this._i.GetCellGridLineWeight(row,col,edge);
		}

		///<summary>
		///
		///</summary>
		public void SetCellGridLineWeight(int row,int col,int edges,dynamic Lineweight) 
		{
			this._i.SetCellGridLineWeight(row,col,edges,Lineweight);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellGridColor(int row,int col,Autodesk.AutoCAD.Interop.Common.AcCellEdgeMask edge) 
		{
			return this._i.GetCellGridColor(row,col,edge);
		}

		///<summary>
		///
		///</summary>
		public void SetCellGridColor(int row,int col,int edges,dynamic pColor) 
		{
			this._i.SetCellGridColor(row,col,edges,pColor);
		}

		///<summary>
		///
		///</summary>
		public bool GetCellGridVisibility(int row,int col,Autodesk.AutoCAD.Interop.Common.AcCellEdgeMask edge) 
		{
			return this._i.GetCellGridVisibility(row,col,edge);
		}

		///<summary>
		///
		///</summary>
		public void SetCellGridVisibility(int row,int col,int edges,bool bValue) 
		{
			this._i.SetCellGridVisibility(row,col,edges,bValue);
		}

		///<summary>
		///
		///</summary>
		public void InsertColumns(int col,double Width,int cols) 
		{
			this._i.InsertColumns(col,Width,cols);
		}

		///<summary>
		///
		///</summary>
		public void DeleteColumns(int col,int cols) 
		{
			this._i.DeleteColumns(col,cols);
		}

		///<summary>
		///
		///</summary>
		public void InsertRows(int row,double Height,int Rows) 
		{
			this._i.InsertRows(row,Height,Rows);
		}

		///<summary>
		///
		///</summary>
		public void DeleteRows(int row,int Rows) 
		{
			this._i.DeleteRows(row,Rows);
		}

		///<summary>
		///
		///</summary>
		public void MergeCells(int minRow,int maxRow,int minCol,int maxCol) 
		{
			this._i.MergeCells(minRow,maxRow,minCol,maxCol);
		}

		///<summary>
		///
		///</summary>
		public void UnmergeCells(int minRow,int maxRow,int minCol,int maxCol) 
		{
			this._i.UnmergeCells(minRow,maxRow,minCol,maxCol);
		}

		///<summary>
		///
		///</summary>
		public bool IsMergedCell(int row,int col,int minRow, int maxRow, int minCol, int maxCol) 
		{
			bool data = this._i.IsMergedCell(row,col,out minRow,out maxRow,out minCol,out maxCol);
			return data;
		}

		///<summary>
		///
		///</summary>
		public dynamic GetFieldId(int row,int col) 
		{
			return this._i.GetFieldId(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetFieldId(int row,int col,dynamic fieldId) 
		{
			this._i.SetFieldId(row,col,fieldId);
		}

		///<summary>
		///
		///</summary>
		public void GenerateLayout() 
		{
			this._i.GenerateLayout();
		}

		///<summary>
		///
		///</summary>
		public void RecomputeTableBlock(bool bForceUpdate) 
		{
			this._i.RecomputeTableBlock(bForceUpdate);
		}

		///<summary>
		///
		///</summary>
		public bool HitTest(object wpt,object wviewVec)
        {
			int resultRowIndex;
			int resultColumnIndex;

            bool data =  this._i.HitTest(wpt,wviewVec,out resultRowIndex,out resultColumnIndex);
			return data;
		}

		///<summary>
		///
		///</summary>
		public void SetSubSelection(int rowMin,int rowMax,int colMin,int colMax) 
		{
			this._i.SetSubSelection(rowMin,rowMax,colMin,colMax);
		}

		///<summary>
		///
		///</summary>
		public void ClearSubSelection() 
		{
			this._i.ClearSubSelection();
		}

		///<summary>
		///
		///</summary>
		public bool HasSubSelection => this._i.HasSubSelection;

		///<summary>
		///
		///</summary>
		public bool RegenerateTableSuppressed => this._i.RegenerateTableSuppressed;

		///<summary>
		///
		///</summary>
		public void Set_RegenerateTableSuppressed(bool bValue) 
		{
			this._i.RegenerateTableSuppressed = bValue;
		}

		///<summary>
		///
		///</summary>
		public List<object> GetDataType(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			Autodesk.AutoCAD.Interop.Common.AcValueDataType pDataType;
			Autodesk.AutoCAD.Interop.Common.AcValueUnitType pUnitType;

            this._i.GetDataType(rowType,out pDataType,out pUnitType);
			return new List<object> { pDataType, pUnitType };
		}

		///<summary>
		///
		///</summary>
		public void SetDataType(int rowTypes,Autodesk.AutoCAD.Interop.Common.AcValueDataType dataType,Autodesk.AutoCAD.Interop.Common.AcValueUnitType unitType) 
		{
			this._i.SetDataType(rowTypes,dataType,unitType);
		}

		///<summary>
		///
		///</summary>
		public string GetFormat(Autodesk.AutoCAD.Interop.Common.AcRowType rowType) 
		{
			return this._i.GetFormat(rowType);
		}

		///<summary>
		///
		///</summary>
		public void SetFormat(int rowTypes, string pFormat) 
		{
			this._i.SetFormat(rowTypes, pFormat);
		}

		///<summary>
		///
		///</summary>
		public string FormatValue(int row,int col, Autodesk.AutoCAD.Interop.Common.AcFormatOption option, string current_value) 
		{
			this._i.FormatValue(row,col, option, ref current_value);
			return current_value;
		}

		///<summary>
		///
		///</summary>
		public List<object> GetCellDataType(int row,int col) 
		{
            Autodesk.AutoCAD.Interop.Common.AcValueDataType pDataType;
            Autodesk.AutoCAD.Interop.Common.AcValueUnitType pUnitType;

            this._i.GetCellDataType(row,col,out pDataType,out pUnitType);
			return new List<object> { pDataType, pUnitType };
		}

		///<summary>
		///
		///</summary>
		public void SetCellDataType(int row,int col, Autodesk.AutoCAD.Interop.Common.AcValueDataType dataType, Autodesk.AutoCAD.Interop.Common.AcValueUnitType unitType) 
		{
			this._i.SetCellDataType(row,col, dataType, unitType);
		}

		///<summary>
		///
		///</summary>
		public string GetCellFormat(int row,int col) 
		{
			return this._i.GetCellFormat(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellFormat(int row,int col, string pFormat) 
		{
			this._i.SetCellFormat(row,col, pFormat);
		}

		///<summary>
		///
		///</summary>
		public object GetCellValue(int row,int col) 
		{
			return this._i.GetCellValue(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetCellValue(int row,int col, object cValue) 
		{
			this._i.SetCellValue(row,col, cValue);
		}

		///<summary>
		///
		///</summary>
		public void SetCellValueFromText(int row,int col,string val,Autodesk.AutoCAD.Interop.Common.AcParseOption nOption) 
		{
			this._i.SetCellValueFromText(row,col,val,nOption);
		}

		///<summary>
		///
		///</summary>
		public void ResetCellValue(int row,int col) 
		{
			this._i.ResetCellValue(row,col);
		}

		///<summary>
		///
		///</summary>
		public bool IsEmpty(int nRow,int nCol) 
		{
			return this._i.IsEmpty(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public int CreateContent(int nRow,int nCol,int nIndex) 
		{
			return this._i.CreateContent(nRow,nCol,nIndex);
		}

		///<summary>
		///
		///</summary>
		public void MoveContent(int nRow,int nCol,int nFromIndex,int nToIndex) 
		{
			this._i.MoveContent(nRow,nCol,nFromIndex,nToIndex);
		}

		///<summary>
		///
		///</summary>
		public void DeleteContent(int nRow,int nCol) 
		{
			this._i.DeleteContent(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public object GetValue(int nRow,int nCol,int nContent) 
		{
			return this._i.GetValue(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetValue(int nRow,int nCol,int nContent,object acValue) 
		{
			this._i.SetValue(nRow,nCol,nContent,acValue);
		}

		///<summary>
		///
		///</summary>
		public void SetValueFromText(int nRow,int nCol,int nContent,string szText,Autodesk.AutoCAD.Interop.Common.AcParseOption nOption) 
		{
			this._i.SetValueFromText(nRow,nCol,nContent,szText,nOption);
		}

		///<summary>
		///
		///</summary>
		public string GetDataFormat(int nRow,int nCol,int nContent) 
		{
			return this._i.GetDataFormat(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetDataFormat(int nRow,int nCol,int nContent,string szFormat) 
		{
			this._i.SetDataFormat(nRow,nCol,nContent,szFormat);
		}

		///<summary>
		///
		///</summary>
		public string GetTextString(int nRow,int nCol,int nContent) 
		{
			return this._i.GetTextString(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetTextString(int nRow,int nCol,int nContent,string Text) 
		{
			this._i.SetTextString(nRow,nCol,nContent,Text);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetFieldId2(int nRow,int nCol,int nContent) 
		{
			return this._i.GetFieldId2(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetFieldId2(int nRow,int nCol,int nContent,dynamic acDbObjectId,Autodesk.AutoCAD.Interop.Common.AcCellOption nflag) 
		{
			this._i.SetFieldId2(nRow,nCol,nContent,acDbObjectId,nflag);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetBlockTableRecordId2(int nRow,int nCol,int nContent) 
		{
			return this._i.GetBlockTableRecordId2(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockTableRecordId2(int nRow,int nCol,int nContent,dynamic blkId,bool autoFit) 
		{
			this._i.SetBlockTableRecordId2(nRow,nCol,nContent,blkId,autoFit);
		}

		///<summary>
		///
		///</summary>
		public string GetBlockAttributeValue2(int nRow,int nCol,int nContent,dynamic blkId) 
		{
			return this._i.GetBlockAttributeValue2(nRow,nCol,nContent,blkId);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockAttributeValue2(int nRow,int nCol,int nContent,dynamic blkId,string Value) 
		{
			this._i.SetBlockAttributeValue2(nRow,nCol,nContent,blkId,Value);
		}

		///<summary>
		///
		///</summary>
		public object GetCustomData(int nRow,int nCol,string szKey) 
		{
			object pData;

            this._i.GetCustomData(nRow,nCol,szKey,out pData);
			return pData;
		}

		///<summary>
		///
		///</summary>
		public void SetCustomData(int nRow,int nCol,string szKey,object data) 
		{
			this._i.SetCustomData(nRow,nCol,szKey,data);
		}

		///<summary>
		///
		///</summary>
		public string GetCellStyle(int nRow,int nCol) 
		{
			return this._i.GetCellStyle(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public void SetCellStyle(int nRow,int nCol,string szCellStyle) 
		{
			this._i.SetCellStyle(nRow,nCol,szCellStyle);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetContentColor2(int nRow,int nCol,int nContent) 
		{
			return this._i.GetContentColor2(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetContentColor2(int nRow,int nCol,int nContent,dynamic pColor) 
		{
			this._i.SetContentColor2(nRow,nCol,nContent,pColor);
		}

		

		///<summary>
		///
		///</summary>
		public double GetRotation(int nRow,int nCol,int nContent) 
		{
			return this._i.GetRotation(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetRotation(int nRow,int nCol,int nContent,double Value) 
		{
			this._i.SetRotation(nRow,nCol,nContent,Value);
		}

		

		///<summary>
		///
		///</summary>
		public double GetScale(int nRow,int nCol,int nContent) 
		{
			return this._i.GetScale(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetScale(int nRow,int nCol,int nContent,double scale) 
		{
			this._i.SetScale(nRow,nCol,nContent,scale);
		}

		///<summary>
		///
		///</summary>
		public void RemoveAllOverrides(int nRow,int nCol) 
		{
			this._i.RemoveAllOverrides(nRow,nCol);
		}

		
		///<summary>
		///
		///</summary>
		public dynamic GetGridLinetype(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcGridLineType nGridLineType) 
		{
			return this._i.GetGridLinetype(nRow,nCol,nGridLineType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridLinetype(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcGridLineType nGridLineType,dynamic idLinetype) 
		{
			this._i.SetGridLinetype(nRow,nCol,nGridLineType,idLinetype);
		}

		

		///<summary>
		///
		///</summary>
		public double GetGridDoubleLineSpacing(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcGridLineType nGridLineType) 
		{
			return this._i.GetGridDoubleLineSpacing(nRow,nCol,nGridLineType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridDoubleLineSpacing(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcGridLineType nGridLineType,double fSpacing) 
		{
			this._i.SetGridDoubleLineSpacing(nRow,nCol,nGridLineType,fSpacing);
		}

		///<summary>
		///
		///</summary>
		public void Set_EnableBreak(bool rhs) 
		{
			this._i.EnableBreak = rhs;
		}

		///<summary>
		///
		///</summary>
		public double GetBreakHeight(int nIndex) 
		{
			return this._i.GetBreakHeight(nIndex);
		}

		///<summary>
		///
		///</summary>
		public void SetBreakHeight(int nIndex,double Height) 
		{
			this._i.SetBreakHeight(nIndex,Height);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetContentType(int nRow,int nCol) 
		{
			return this._i.GetContentType(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public double GetMargin(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcCellMargin nMargin) 
		{
			return this._i.GetMargin(nRow,nCol,nMargin);
		}

		///<summary>
		///
		///</summary>
		public void SetMargin(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcCellMargin nMargins,double fMargin) 
		{
			this._i.SetMargin(nRow,nCol,nMargins,fMargin);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetContentLayout(int row,int col) 
		{
			return this._i.GetContentLayout(row,col);
		}

		///<summary>
		///
		///</summary>
		public void SetContentLayout(int row,int col,Autodesk.AutoCAD.Interop.Common.AcCellContentLayout nLayout) 
		{
			this._i.SetContentLayout(row,col,nLayout);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetOverride(int nRow,int nCol,int nContent) 
		{
			return this._i.GetOverride(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetOverride(int nRow,int nCol,int nContent,Autodesk.AutoCAD.Interop.Common.AcCellProperty nProp) 
		{
			this._i.SetOverride(nRow,nCol,nContent,nProp);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetGridLineStyle(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcGridLineType nGridLineType) 
		{
			return this._i.GetGridLineStyle(nRow,nCol,nGridLineType);
		}

		///<summary>
		///
		///</summary>
		public void SetGridLineStyle(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcGridLineType nGridLineTypes,Autodesk.AutoCAD.Interop.Common.AcGridLineStyle nLineStyle) 
		{
			this._i.SetGridLineStyle(nRow,nCol,nGridLineTypes,nLineStyle);
		}

		///<summary>
		///
		///</summary>
		public void InsertRowsAndInherit(int nIndex,int nInheritFrom,int nNumRows) 
		{
			this._i.InsertRowsAndInherit(nIndex,nInheritFrom,nNumRows);
		}

		///<summary>
		///
		///</summary>
		public void InsertColumnsAndInherit(int col,int nInheritFrom,int nNumCols) 
		{
			this._i.InsertColumnsAndInherit(col,nInheritFrom,nNumCols);
		}

		///<summary>
		///
		///</summary>
		public bool GetHasFormula(int nRow,int nCol,int nContent) 
		{
			return this._i.GetHasFormula(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public string GetFormula(int nRow,int nCol,int nContent) 
		{
			return this._i.GetFormula(nRow,nCol,nContent);
		}

		///<summary>
		///
		///</summary>
		public void SetFormula(int nRow,int nCol,int nContent,string pszFormula) 
		{
			this._i.SetFormula(nRow,nCol,nContent,pszFormula);
		}

		///<summary>
		///
		///</summary>
		public bool IsContentEditable(int nRow,int nCol) 
		{
			return this._i.IsContentEditable(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public bool IsFormatEditable(int nRow,int nCol) 
		{
			return this._i.IsFormatEditable(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetCellState(int nRow,int nCol) 
		{
			return this._i.GetCellState(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public void SetCellState(int nRow,int nCol,Autodesk.AutoCAD.Interop.Common.AcCellState nLock) 
		{
			this._i.SetCellState(nRow,nCol,nLock);
		}

		///<summary>
		///
		///</summary>
		public void EnableMergeAll(int nRow,int nCol,bool bEnable) 
		{
			this._i.EnableMergeAll(nRow,nCol,bEnable);
		}

		///<summary>
		///
		///</summary>
		public bool IsMergeAllEnabled(int nRow,int nCol) 
		{
			return this._i.IsMergeAllEnabled(nRow,nCol);
		}

		///<summary>
		///
		///</summary>
		public bool BreaksEnabled => this._i.BreaksEnabled;

		///<summary>
		///
		///</summary>
		public void Set_BreaksEnabled(bool bEnabled) 
		{
			this._i.BreaksEnabled = bEnabled;
		}

		///<summary>
		///
		///</summary>
		public bool RepeatTopLabels => this._i.RepeatTopLabels;

		///<summary>
		///
		///</summary>
		public void Set_RepeatTopLabels(bool bEnabled) 
		{
			this._i.RepeatTopLabels = bEnabled;
		}

		///<summary>
		///
		///</summary>
		public bool RepeatBottomLabels => this._i.RepeatBottomLabels;

		///<summary>
		///
		///</summary>
		public void Set_RepeatBottomLabels(bool bEnabled) 
		{
			this._i.RepeatBottomLabels = bEnabled;
		}

		///<summary>
		///
		///</summary>
		public dynamic TableBreakFlowDirection => this._i.TableBreakFlowDirection;

		///<summary>
		///
		///</summary>
		public void Set_TableBreakFlowDirection(Autodesk.AutoCAD.Interop.Common.AcTableFlowDirection pDir) 
		{
			this._i.TableBreakFlowDirection = pDir;
		}

		///<summary>
		///
		///</summary>
		public bool AllowManualPositions => this._i.AllowManualPositions;

		///<summary>
		///
		///</summary>
		public void Set_AllowManualPositions(bool bEnabled) 
		{
			this._i.AllowManualPositions = bEnabled;
		}

		///<summary>
		///
		///</summary>
		public bool AllowManualHeights => this._i.AllowManualHeights;

		///<summary>
		///
		///</summary>
		public void Set_AllowManualHeights(bool bEnabled) 
		{
			this._i.AllowManualHeights = bEnabled;
		}

		///<summary>
		///
		///</summary>
		public double TableBreakHeight => this._i.TableBreakHeight;

		///<summary>
		///
		///</summary>
		public void Set_TableBreakHeight(double pHeight) 
		{
			this._i.TableBreakHeight = pHeight;
		}

		///<summary>
		///
		///</summary>
		public double BreakSpacing => this._i.BreakSpacing;

		///<summary>
		///
		///</summary>
		public void Set_BreakSpacing(double pSpacing) 
		{
			this._i.BreakSpacing = pSpacing;
		}

		///<summary>
		///
		///</summary>
		public string GetColumnName(int nIndex) 
		{
			return this._i.GetColumnName(nIndex);
		}

		///<summary>
		///
		///</summary>
		public void SetColumnName(int nIndex,string Name) 
		{
			this._i.SetColumnName(nIndex,Name);
		}

		///<summary>
		///
		///</summary>
		public void SetToolTip(int nRow,int nCol,string tip) 
		{
			this._i.SetToolTip(nRow,nCol,tip);
		}
	}
}
