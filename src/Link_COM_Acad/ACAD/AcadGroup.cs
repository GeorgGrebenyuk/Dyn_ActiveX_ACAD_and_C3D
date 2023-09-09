namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGroup 
	{
		public AXDBLib.IAcadGroup _i;
		internal AcadGroup(object AcadGroup_object) 
		{
			this._i = AcadGroup_object as AXDBLib.IAcadGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///0x00020120
		///</summary>
		public void Set_TrueColor(dynamic rhs) 
		{
			this._i.TrueColor = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Layer(string rhs) 
		{
			this._i.Layer = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Linetype(string rhs) 
		{
			this._i.Linetype = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_LinetypeScale(dynamic rhs) 
		{
			this._i.LinetypeScale = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Visible(bool rhs) 
		{
			this._i.Visible = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Highlight(bool HighlightFlag) 
		{
			this._i.Highlight(HighlightFlag);
		}

		///<summary>
		///
		///</summary>
		public void Set_PlotStyleName(string rhs) 
		{
			this._i.PlotStyleName = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Lineweight(dynamic rhs) 
		{
			this._i.Lineweight = rhs;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public void AppendItems(object Objects) 
		{
			this._i.AppendItems(Objects);
		}

		///<summary>
		///
		///</summary>
		public void RemoveItems(object Objects) 
		{
			this._i.RemoveItems(Objects);
		}

		///<summary>
		///
		///</summary>
		public void Update() 
		{
			this._i.Update();
		}

		///<summary>
		///
		///</summary>
		public void Set_Material(string rhs) 
		{
			this._i.Material = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_color(AXDBLib.AcColor rhs) 
		{
			this._i.color = rhs;
		}
	}
}
