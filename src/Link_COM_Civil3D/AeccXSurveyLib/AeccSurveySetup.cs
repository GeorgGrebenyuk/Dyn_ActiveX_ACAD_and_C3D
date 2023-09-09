namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveySetup 
	{
		public AeccXSurveyLib.IAeccSurveySetup _i;
		internal AeccSurveySetup(object AeccSurveySetup_object) 
		{
			this._i = AeccSurveySetup_object as AeccXSurveyLib.IAeccSurveySetup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public dynamic Network => this._i.Network;

		///<summary>
		///
		///</summary>
		public dynamic Project => this._i.Project;

		///<summary>
		///
		///</summary>
		public dynamic Observations => this._i.Observations;

		///<summary>
		///
		///</summary>
		public dynamic AveragedPoints => this._i.AveragedPoints;

		///<summary>
		///
		///</summary>
		public dynamic StationPointNumber => this._i.StationPointNumber;

		///<summary>
		///
		///</summary>
		public dynamic BacksightPointNumber => this._i.BacksightPointNumber;

		///<summary>
		///
		///</summary>
		public double BacksightDirection => this._i.BacksightDirection;

		///<summary>
		///
		///</summary>
		public void Set_BacksightDirection(double pdBacksightDirection) 
		{
			this._i.BacksightDirection = pdBacksightDirection;
		}

		///<summary>
		///
		///</summary>
		public double BacksightOrientation => this._i.BacksightOrientation;

		///<summary>
		///
		///</summary>
		public void Set_BacksightOrientation(double pdBacksightOrientation) 
		{
			this._i.BacksightOrientation = pdBacksightOrientation;
		}

		///<summary>
		///
		///</summary>
		public double BacksightFace1 => this._i.BacksightFace1;

		///<summary>
		///
		///</summary>
		public void Set_BacksightFace1(double pdFace1) 
		{
			this._i.BacksightFace1 = pdFace1;
		}

		///<summary>
		///
		///</summary>
		public double BacksightFace2 => this._i.BacksightFace2;

		///<summary>
		///
		///</summary>
		public void Set_BacksightFace2(double pdFace2) 
		{
			this._i.BacksightFace2 = pdFace2;
		}

		///<summary>
		///
		///</summary>
		public double InstrumentHeight => this._i.InstrumentHeight;

		///<summary>
		///
		///</summary>
		public void Set_InstrumentHeight(double pdTheodoliteHeight) 
		{
			this._i.InstrumentHeight = pdTheodoliteHeight;
		}

		///<summary>
		///
		///</summary>
		public double InstrumentElevation => this._i.InstrumentElevation;

		///<summary>
		///
		///</summary>
		public double Easting => this._i.Easting;

		///<summary>
		///
		///</summary>
		public double Northing => this._i.Northing;

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public double Longitude => this._i.Longitude;

		///<summary>
		///
		///</summary>
		public double Latitude => this._i.Latitude;

		///<summary>
		///
		///</summary>
		public bool AzimuthFlag => this._i.AzimuthFlag;

		///<summary>
		///
		///</summary>
		public void Set_AzimuthFlag(bool pbAzimuthFlag) 
		{
			this._i.AzimuthFlag = pbAzimuthFlag;
		}

		///<summary>
		///
		///</summary>
		public bool UserAzimuth => this._i.UserAzimuth;

		///<summary>
		///
		///</summary>
		public void Set_UserAzimuth(bool pbUserAzimuth) 
		{
			this._i.UserAzimuth = pbUserAzimuth;
		}
	}
}
