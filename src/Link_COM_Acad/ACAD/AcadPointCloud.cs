namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPointCloud 
	{
		public AXDBLib.IAcadPointCloud _i;
		internal AcadPointCloud(object AcadPointCloud_object) 
		{
			this._i = AcadPointCloud_object as AXDBLib.IAcadPointCloud;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UseEntityColor => this._i.UseEntityColor;

		///<summary>
		///
		///</summary>
		public void Set_UseEntityColor(AXDBLib.AcPointCloudColorType val) 
		{
			this._i.UseEntityColor = val;
		}

		///<summary>
		///
		///</summary>
		public bool ShowIntensity => this._i.ShowIntensity;

		///<summary>
		///
		///</summary>
		public void Set_ShowIntensity(bool val) 
		{
			this._i.ShowIntensity = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic IntensityColorScheme => this._i.IntensityColorScheme;

		///<summary>
		///
		///</summary>
		public void Set_IntensityColorScheme(AXDBLib.AcPointCloudIntensityStyle val) 
		{
			this._i.IntensityColorScheme = val;
		}

		///<summary>
		///
		///</summary>
		public object InsertionPoint => this._i.InsertionPoint;

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(object EndPoint) 
		{
			this._i.InsertionPoint = EndPoint;
		}

		///<summary>
		///
		///</summary>
		public dynamic Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(dynamic val) 
		{
			this._i.Rotation = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(dynamic val) 
		{
			this._i.Width = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public void Set_Length(dynamic val) 
		{
			this._i.Length = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(dynamic val) 
		{
			this._i.Height = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic scale => this._i.scale;

		///<summary>
		///
		///</summary>
		public void Set_scale(dynamic val) 
		{
			this._i.scale = val;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public bool ShowClipped => this._i.ShowClipped;

		///<summary>
		///
		///</summary>
		public void Set_ShowClipped(bool val) 
		{
			this._i.ShowClipped = val;
		}

		///<summary>
		///
		///</summary>
		public bool Locked => this._i.Locked;

		///<summary>
		///
		///</summary>
		public void Set_Locked(bool val) 
		{
			this._i.Locked = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic Stylization => this._i.Stylization;

		///<summary>
		///
		///</summary>
		public void Set_Stylization(AXDBLib.AcPointCloudStylizationType val) 
		{
			this._i.Stylization = val;
		}

		///<summary>
		///
		///</summary>
		public string Unit => this._i.Unit;

		///<summary>
		///
		///</summary>
		public dynamic UnitFactor => this._i.UnitFactor;
	}
}
