namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointDescriptionKey 
	{
		public Autodesk.AECC.Interop.Land.IAeccPointDescriptionKey _i;
		internal AeccPointDescriptionKey(object AeccPointDescriptionKey_object) 
		{
			this._i = AeccPointDescriptionKey_object as Autodesk.AECC.Interop.Land.IAeccPointDescriptionKey;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Format => this._i.Format;

		///<summary>
		///
		///</summary>
		public void Set_Format(string pVal) 
		{
			this._i.Format = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PointStyle => this._i.PointStyle;

		///<summary>
		///
		///</summary>
		public void Set_PointStyle(object pVal) 
		{
			this._i.PointStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PointLabelStyle => this._i.PointLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_PointLabelStyle(object pVal) 
		{
			this._i.PointLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

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
		public bool ScaleXY => this._i.ScaleXY;

		///<summary>
		///
		///</summary>
		public void Set_ScaleXY(bool pVal) 
		{
			this._i.ScaleXY = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ScaleZ => this._i.ScaleZ;

		///<summary>
		///
		///</summary>
		public void Set_ScaleZ(bool pVal) 
		{
			this._i.ScaleZ = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ClockwiseRotation => this._i.ClockwiseRotation;

		///<summary>
		///
		///</summary>
		public void Set_ClockwiseRotation(bool pVal) 
		{
			this._i.ClockwiseRotation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDrawingScale => this._i.UseDrawingScale;

		///<summary>
		///
		///</summary>
		public void Set_UseDrawingScale(bool pVal) 
		{
			this._i.UseDrawingScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public double FixedScaleFactor => this._i.FixedScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_FixedScaleFactor(double pVal) 
		{
			this._i.FixedScaleFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public double FixedRotation => this._i.FixedRotation;

		///<summary>
		///
		///</summary>
		public void Set_FixedRotation(double pVal) 
		{
			this._i.FixedRotation = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ScaleParameter => this._i.ScaleParameter;

		///<summary>
		///
		///</summary>
		public void Set_ScaleParameter(dynamic pVal) 
		{
			this._i.ScaleParameter = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic RotationParameter => this._i.RotationParameter;

		///<summary>
		///
		///</summary>
		public void Set_RotationParameter(dynamic pVal) 
		{
			this._i.RotationParameter = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverridePointStyle => this._i.OverridePointStyle;

		///<summary>
		///
		///</summary>
		public void Set_OverridePointStyle(bool pVal) 
		{
			this._i.OverridePointStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverridePointLabelStyle => this._i.OverridePointLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_OverridePointLabelStyle(bool pVal) 
		{
			this._i.OverridePointLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideLayer => this._i.OverrideLayer;

		///<summary>
		///
		///</summary>
		public void Set_OverrideLayer(bool pVal) 
		{
			this._i.OverrideLayer = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideScaleParameter => this._i.OverrideScaleParameter;

		///<summary>
		///
		///</summary>
		public void Set_OverrideScaleParameter(bool pVal) 
		{
			this._i.OverrideScaleParameter = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideRotationParameter => this._i.OverrideRotationParameter;

		///<summary>
		///
		///</summary>
		public void Set_OverrideRotationParameter(bool pVal) 
		{
			this._i.OverrideRotationParameter = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideFixedScaleFactor => this._i.OverrideFixedScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_OverrideFixedScaleFactor(bool pVal) 
		{
			this._i.OverrideFixedScaleFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideFixedRotation => this._i.OverrideFixedRotation;

		///<summary>
		///
		///</summary>
		public void Set_OverrideFixedRotation(bool pVal) 
		{
			this._i.OverrideFixedRotation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double FixedLabelRotation => this._i.FixedLabelRotation;

		///<summary>
		///
		///</summary>
		public void Set_FixedLabelRotation(double pVal) 
		{
			this._i.FixedLabelRotation = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelRotationParameter => this._i.LabelRotationParameter;

		///<summary>
		///
		///</summary>
		public void Set_LabelRotationParameter(dynamic pVal) 
		{
			this._i.LabelRotationParameter = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideLabelRotationParameter => this._i.OverrideLabelRotationParameter;

		///<summary>
		///
		///</summary>
		public void Set_OverrideLabelRotationParameter(bool pVal) 
		{
			this._i.OverrideLabelRotationParameter = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideLabelFixedRotation => this._i.OverrideLabelFixedRotation;

		///<summary>
		///
		///</summary>
		public void Set_OverrideLabelFixedRotation(bool pVal) 
		{
			this._i.OverrideLabelFixedRotation = pVal;
		}
	}
}
