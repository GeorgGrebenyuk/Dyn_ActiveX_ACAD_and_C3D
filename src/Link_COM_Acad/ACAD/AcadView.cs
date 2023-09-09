namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadView 
	{
		public AXDBLib.IAcadView _i;
		internal AcadView(object AcadView_object) 
		{
			this._i = AcadView_object as AXDBLib.IAcadView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Center => this._i.Center;

		///<summary>
		///
		///</summary>
		public void Set_Center(object Center) 
		{
			this._i.Center = Center;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double Width) 
		{
			this._i.Width = Width;
		}

		///<summary>
		///
		///</summary>
		public object Target => this._i.Target;

		///<summary>
		///
		///</summary>
		public void Set_Target(object targetPoint) 
		{
			this._i.Target = targetPoint;
		}

		///<summary>
		///
		///</summary>
		public object Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public void Set_Direction(object dirVec) 
		{
			this._i.Direction = dirVec;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}

		///<summary>
		///
		///</summary>
		public string CategoryName => this._i.CategoryName;

		///<summary>
		///
		///</summary>
		public void Set_CategoryName(string category) 
		{
			this._i.CategoryName = category;
		}

		///<summary>
		///
		///</summary>
		public dynamic LayoutId => this._i.LayoutId;

		///<summary>
		///
		///</summary>
		public void Set_LayoutId(dynamic ObjectID) 
		{
			this._i.LayoutId = ObjectID;
		}

		///<summary>
		///
		///</summary>
		public string LayerState => this._i.LayerState;

		///<summary>
		///
		///</summary>
		public void Set_LayerState(string LayerState) 
		{
			this._i.LayerState = LayerState;
		}

		///<summary>
		///
		///</summary>
		public bool HasVpAssociation => this._i.HasVpAssociation;

		///<summary>
		///
		///</summary>
		public void Set_HasVpAssociation(bool bVpAssoc) 
		{
			this._i.HasVpAssociation = bVpAssoc;
		}
	}
}
