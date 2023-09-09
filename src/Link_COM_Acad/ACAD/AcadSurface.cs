﻿namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSurface 
	{
		public AXDBLib.IAcadSurface _i;
		internal AcadSurface(object AcadSurface_object) 
		{
			this._i = AcadSurface_object as AXDBLib.IAcadSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string SurfaceType => this._i.SurfaceType;

		///<summary>
		///
		///</summary>
		public dynamic UIsolineDensity => this._i.UIsolineDensity;

		///<summary>
		///
		///</summary>
		public void Set_UIsolineDensity(dynamic density) 
		{
			this._i.UIsolineDensity = density;
		}

		///<summary>
		///
		///</summary>
		public dynamic VIsolineDensity => this._i.VIsolineDensity;

		///<summary>
		///
		///</summary>
		public void Set_VIsolineDensity(dynamic density) 
		{
			this._i.VIsolineDensity = density;
		}

		///<summary>
		///
		///</summary>
		public dynamic WireframeType => this._i.WireframeType;

		///<summary>
		///
		///</summary>
		public void Set_WireframeType(AXDBLib.AcWireframeType Type) 
		{
			this._i.WireframeType = Type;
		}

		///<summary>
		///
		///</summary>
		public int MaintainAssociativity => this._i.MaintainAssociativity;

		///<summary>
		///
		///</summary>
		public void Set_MaintainAssociativity(int maintainAssoc) 
		{
			this._i.MaintainAssociativity = maintainAssoc;
		}

		///<summary>
		///
		///</summary>
		public bool ShowAssociativity => this._i.ShowAssociativity;

		///<summary>
		///
		///</summary>
		public void Set_ShowAssociativity(bool bEnabled) 
		{
			this._i.ShowAssociativity = bEnabled;
		}

		///<summary>
		///
		///</summary>
		public object EdgeExtensionDistances => this._i.EdgeExtensionDistances;

		///<summary>
		///
		///</summary>
		public void Set_EdgeExtensionDistances(object extDistances) 
		{
			this._i.EdgeExtensionDistances = extDistances;
		}

		///<summary>
		///
		///</summary>
		public object SurfTrimAssociativity => this._i.SurfTrimAssociativity;

		///<summary>
		///
		///</summary>
		public void Set_SurfTrimAssociativity(object associative) 
		{
			this._i.SurfTrimAssociativity = associative;
		}
	}
}