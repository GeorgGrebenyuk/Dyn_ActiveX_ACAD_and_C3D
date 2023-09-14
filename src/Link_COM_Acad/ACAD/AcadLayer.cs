namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLayer 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadLayer _i;
		internal AcadLayer(object AcadLayer_object) 
		{
			this._i = AcadLayer_object as Autodesk.AutoCAD.Interop.Common.AcadLayer;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Create new layer with unique name
		/// </summary>
		/// <param name="AcadLayers"></param>
		/// <param name="name"></param>
		public AcadLayer (AcadLayers AcadLayers, string name)
		{
			try
			{
                this._i = AcadLayers._i.Add(name);
            }
			catch (System.Exception ex) { throw ex; };

        }

		///<summary>
		///
		///</summary>
		public object color => this._i.color;

		///<summary>
		///
		///</summary>
		public void Set_color(Autodesk.AutoCAD.Interop.Common.AcColor color) 
		{
			this._i.color = color;
		}

		///<summary>
		///
		///</summary>
		public AcadAcCmColor TrueColor => new AcadAcCmColor(this._i.TrueColor);

		///<summary>
		///
		///</summary>
		public void Set_TrueColor(AcadAcCmColor pColor) 
		{
			this._i.TrueColor = pColor._i;
		}

		///<summary>
		///
		///</summary>
		public bool Freeze => this._i.Freeze;

		///<summary>
		///
		///</summary>
		public void Set_Freeze(bool bFreeze) 
		{
			this._i.Freeze = bFreeze;
		}

		///<summary>
		///
		///</summary>
		public bool LayerOn => this._i.LayerOn;

		///<summary>
		///
		///</summary>
		public void Set_LayerOn(bool bOn) 
		{
			this._i.LayerOn = bOn;
		}

		///<summary>
		///
		///</summary>
		public string Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public void Set_Linetype(string Linetype) 
		{
			this._i.Linetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public bool Lock => this._i.Lock;

		///<summary>
		///
		///</summary>
		public void Set_Lock(bool Block) 
		{
			this._i.Lock = Block;
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
		public bool Plottable => this._i.Plottable;

		///<summary>
		///
		///</summary>
		public void Set_Plottable(bool bPlottable) 
		{
			this._i.Plottable = bPlottable;
		}

		///<summary>
		///
		///</summary>
		public bool ViewportDefault => this._i.ViewportDefault;

		///<summary>
		///
		///</summary>
		public void Set_ViewportDefault(bool bDefault) 
		{
			this._i.ViewportDefault = bDefault;
		}

		///<summary>
		///
		///</summary>
		public string PlotStyleName => this._i.PlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_PlotStyleName(string plotStyle) 
		{
			this._i.PlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public void Set_Lineweight(dynamic Lineweight) 
		{
			this._i.Lineweight = Lineweight;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string Description) 
		{
			this._i.Description = Description;
		}

		///<summary>
		///
		///</summary>
		public bool Used => this._i.Used;

		///<summary>
		///
		///</summary>
		public string Material => this._i.Material;

		///<summary>
		///
		///</summary>
		public void Set_Material(string Material) 
		{
			this._i.Material = Material;
		}
	}
}
