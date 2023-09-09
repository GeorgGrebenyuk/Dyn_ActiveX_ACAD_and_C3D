namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsObjectLayer 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsObjectLayer _i;
		internal AeccSettingsObjectLayer(object AeccSettingsObjectLayer_object) 
		{
			this._i = AeccSettingsObjectLayer_object as Autodesk.AECC.Interop.Land.IAeccSettingsObjectLayer;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Layer(string pVal) 
		{
			this._i.Layer = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public void Set_Modifier(Autodesk.AECC.Interop.Land.AeccObjectLayerModifierType pVal) 
		{
			this._i.Modifier = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Modifier => this._i.Modifier;

		///<summary>
		///
		///</summary>
		public void Set_ModifierValue(string pVal) 
		{
			this._i.ModifierValue = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ModifierValue => this._i.ModifierValue;

		///<summary>
		///
		///</summary>
		public void Set_Locked(bool pVal) 
		{
			this._i.Locked = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Locked => this._i.Locked;
	}
}
