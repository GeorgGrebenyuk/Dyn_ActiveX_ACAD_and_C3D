﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateMultipleSectionView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateMultipleSectionView _i;
		internal AeccSettingsCreateMultipleSectionView(object AeccSettingsCreateMultipleSectionView_object) 
		{
			this._i = AeccSettingsCreateMultipleSectionView_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateMultipleSectionView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TableCreationSettings => this._i.TableCreationSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;
	}
}
