namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleDefaults 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleDefaults _i;
		internal AeccLabelStyleDefaults(object AeccLabelStyleDefaults_object) 
		{
			this._i = AeccLabelStyleDefaults_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleDefaults;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ComponentProperties => this._i.ComponentProperties;

		///<summary>
		///
		///</summary>
		public dynamic LabelProperties => this._i.LabelProperties;

		///<summary>
		///
		///</summary>
		public dynamic DraggedComponentStyle => this._i.DraggedComponentStyle;

		///<summary>
		///
		///</summary>
		public dynamic DraggedLeaderStyle => this._i.DraggedLeaderStyle;
	}
}
