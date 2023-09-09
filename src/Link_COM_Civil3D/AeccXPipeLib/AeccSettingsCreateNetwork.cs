﻿namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateNetwork 
	{
		public AeccXPipeLib.IAeccSettingsCreateNetwork _i;
		internal AeccSettingsCreateNetwork(object AeccSettingsCreateNetwork_object) 
		{
			this._i = AeccSettingsCreateNetwork_object as AeccXPipeLib.IAeccSettingsCreateNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelNewPartsSettings => this._i.LabelNewPartsSettings;

		///<summary>
		///
		///</summary>
		public dynamic LayoutCommand => this._i.LayoutCommand;
	}
}
