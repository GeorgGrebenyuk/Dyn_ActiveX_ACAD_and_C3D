namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceContourLabelGroup 
	{
		public AeccXLandLib.IAeccSurfaceContourLabelGroup _i;
		internal AeccSurfaceContourLabelGroup(object AeccSurfaceContourLabelGroup_object) 
		{
			this._i = AeccSurfaceContourLabelGroup_object as AeccXLandLib.IAeccSurfaceContourLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;

		///<summary>
		///
		///</summary>
		public bool IsLabelLineVisible => this._i.IsLabelLineVisible;

		///<summary>
		///
		///</summary>
		public void Set_IsLabelLineVisible(bool pVal) 
		{
			this._i.IsLabelLineVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsMajorLabelVisible => this._i.IsMajorLabelVisible;

		///<summary>
		///
		///</summary>
		public void Set_IsMajorLabelVisible(bool pVal) 
		{
			this._i.IsMajorLabelVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorLabelStyle => this._i.MajorLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_MajorLabelStyle(object pVal) 
		{
			this._i.MajorLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsMinorLabelVisible => this._i.IsMinorLabelVisible;

		///<summary>
		///
		///</summary>
		public void Set_IsMinorLabelVisible(bool pVal) 
		{
			this._i.IsMinorLabelVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MinorLabelStyle => this._i.MinorLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_MinorLabelStyle(object pVal) 
		{
			this._i.MinorLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsUserLabelVisible => this._i.IsUserLabelVisible;

		///<summary>
		///
		///</summary>
		public void Set_IsUserLabelVisible(bool pVal) 
		{
			this._i.IsUserLabelVisible = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic UserLabelStyle => this._i.UserLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_UserLabelStyle(object pVal) 
		{
			this._i.UserLabelStyle = pVal;
		}
	}
}
