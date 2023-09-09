namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsTransformation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsTransformation _i;
		internal AeccSettingsTransformation(object AeccSettingsTransformation_object) 
		{
			this._i = AeccSettingsTransformation_object as Autodesk.AECC.Interop.Land.IAeccSettingsTransformation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool ApplySeaLevelScaleFactor => this._i.ApplySeaLevelScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ApplySeaLevelScaleFactor(bool pVal) 
		{
			this._i.ApplySeaLevelScaleFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ApplyTransformSettings => this._i.ApplyTransformSettings;

		///<summary>
		///
		///</summary>
		public void Set_ApplyTransformSettings(bool pVal) 
		{
			this._i.ApplyTransformSettings = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SpheroidRadius => this._i.SpheroidRadius;

		///<summary>
		///
		///</summary>
		public dynamic GridScaleFactorComputation => this._i.GridScaleFactorComputation;

		///<summary>
		///
		///</summary>
		public void Set_GridScaleFactorComputation(Autodesk.AECC.Interop.Land.AeccGridScaleFactorType pVal) 
		{
			this._i.GridScaleFactorComputation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double GridScaleFactor => this._i.GridScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_GridScaleFactor(double pVal) 
		{
			this._i.GridScaleFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseRotationPoint => this._i.UseRotationPoint;

		///<summary>
		///
		///</summary>
		public void Set_UseRotationPoint(bool pVal) 
		{
			this._i.UseRotationPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public double RotationToGridNorth => this._i.RotationToGridNorth;

		///<summary>
		///
		///</summary>
		public void Set_RotationToGridNorth(double pVal) 
		{
			this._i.RotationToGridNorth = pVal;
		}

		///<summary>
		///
		///</summary>
		public double RotationToGridAzimuth => this._i.RotationToGridAzimuth;

		///<summary>
		///
		///</summary>
		public void Set_RotationToGridAzimuth(double pVal) 
		{
			this._i.RotationToGridAzimuth = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ReferencePoint => this._i.ReferencePoint;

		///<summary>
		///
		///</summary>
		public dynamic RotationPoint => this._i.RotationPoint;

		///<summary>
		///
		///</summary>
		public double SeaLevelScaleElevation => this._i.SeaLevelScaleElevation;

		///<summary>
		///
		///</summary>
		public void Set_SeaLevelScaleElevation(double pVal) 
		{
			this._i.SeaLevelScaleElevation = pVal;
		}
	}
}
