namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccQueryLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccQueryLine _i;
		internal AeccQueryLine(object AeccQueryLine_object) 
		{
			this._i = AeccQueryLine_object as Autodesk.AECC.Interop.Land.IAeccQueryLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_SetOperator(Autodesk.AECC.Interop.Land.AeccQuerySetOperatorType pVal) 
		{
			this._i.SetOperator = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SetOperator => this._i.SetOperator;

		///<summary>
		///
		///</summary>
		public void Set_LeftParenthesis(bool pVal) 
		{
			this._i.LeftParenthesis = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool LeftParenthesis => this._i.LeftParenthesis;

		///<summary>
		///
		///</summary>
		public void Set_Property(Autodesk.AECC.Interop.Land.AeccQueryPropertyType pVal) 
		{
			this._i.Property = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Property => this._i.Property;

		///<summary>
		///
		///</summary>
		public void Set_Operator(Autodesk.AECC.Interop.Land.AeccQueryOperatorType pVal) 
		{
			this._i.Operator = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Operator => this._i.Operator;

		///<summary>
		///
		///</summary>
		public void Set_Value(object pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_RightParenthesis(bool pVal) 
		{
			this._i.RightParenthesis = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool RightParenthesis => this._i.RightParenthesis;

		///<summary>
		///
		///</summary>
		public string LineText => this._i.LineText;
	}
}
